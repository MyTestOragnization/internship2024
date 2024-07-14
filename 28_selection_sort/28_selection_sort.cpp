#include <iostream>
#include <vector>

// Function to perform Selection Sort on an array
void selectionSort(std::vector<int> &arr)
{
    int n = arr.size();

    for (int i = 0; i < n - 1; ++i)
    {
        int minIndex = i; // Index of the smallest element

        for (int j = i + 1; j < n; ++j)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j; // Update minIndex if a smaller element is found
            }
        }

        // Swap the found minimum element with the first element of the unsorted part
        std::swap(arr[minIndex], arr[i]);
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
    std::vector<int> arr = {64, 25, 12, 22, 11};

    std::cout << "Unsorted array: ";
    printArray(arr);

    selectionSort(arr);

    std::cout << "Sorted array: ";
    printArray(arr);

    return 0;
}
