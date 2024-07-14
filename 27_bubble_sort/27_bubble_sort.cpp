#include <iostream>
#include <vector>

// Function to perform Bubble Sort on an array
void bubbleSort(std::vector<int> &arr)
{
    int n = arr.size();
    for (int i = 0; i < n - 1; ++i)
    {
        bool swapped = false; // Flag to check if any swapping happened in this iteration
        for (int j = 0; j < n - i - 1; ++j)
        {
            if (arr[j] > arr[j + 1])
            {
                // Swap arr[j] and arr[j + 1]
                std::swap(arr[j], arr[j + 1]);
                swapped = true;
            }
        }
        // If no elements were swapped, the array is already sorted
        if (!swapped)
        {
            break;
        }
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
    std::vector<int> arr = {64, 34, 25, 12, 22, 11, 90};

    std::cout << "Unsorted array: ";
    printArray(arr);

    bubbleSort(arr);

    std::cout << "Sorted array: ";
    printArray(arr);

    return 0;
}
