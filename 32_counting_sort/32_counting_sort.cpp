#include <iostream>
#include <vector>
#include <algorithm> // For max_element

// Function to perform Counting Sort on an array
void countingSort(std::vector<int> &arr)
{
    // Find the maximum element in the array
    int maxElement = *std::max_element(arr.begin(), arr.end());

    // Create a count array to store the count of each unique element
    std::vector<int> count(maxElement + 1, 0);

    // Store the count of each element
    for (int num : arr)
    {
        count[num]++;
    }

    // Modify the count array such that each element at each index
    // stores the sum of previous counts
    for (int i = 1; i <= maxElement; ++i)
    {
        count[i] += count[i - 1];
    }

    // Output array to store the sorted elements
    std::vector<int> output(arr.size());

    // Build the output array
    for (int i = arr.size() - 1; i >= 0; --i)
    {
        output[count[arr[i]] - 1] = arr[i];
        count[arr[i]]--;
    }

    // Copy the sorted elements into original array
    for (int i = 0; i < arr.size(); ++i)
    {
        arr[i] = output[i];
    }
}

// Function to print the array
void printArray(const std::vector<int> &arr)
{
    for (int num : arr)
    {
        std::cout << num << " ";
    }
    std::cout << std::endl;
}

int main()
{
    std::vector<int> arr = {4, 2, 2, 8, 3, 3, 1, 7};

    std::cout << "Unsorted array: ";
    printArray(arr);

    countingSort(arr);

    std::cout << "Sorted array: ";
    printArray(arr);

    return 0;
}
