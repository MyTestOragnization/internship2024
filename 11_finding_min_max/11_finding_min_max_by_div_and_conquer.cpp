#include <iostream>
#include <vector>
#include <algorithm> // For std::max

// Function to find the maximum element in an array using divide and conquer
int findMax(const std::vector<int> &arr, int low, int high)
{
    // Base case: if the array has one element
    if (low == high)
    {
        return arr[low];
    }

    // Find the middle point
    int mid = low + (high - low) / 2;

    // Recursively find the maximum in the left and right halves
    int maxLeft = findMax(arr, low, mid);
    int maxRight = findMax(arr, mid + 1, high);

    // Return the maximum of the two halves
    return std::max(maxLeft, maxRight);
}

int main()
{
    std::vector<int> arr = {5, 1, 9, 3, 7, 10, 2, 8};

    // Find the maximum element in the array
    int maxElement = findMax(arr, 0, arr.size() - 1);

    std::cout << "Maximum element: " << maxElement << std::endl;

    return 0;
}
