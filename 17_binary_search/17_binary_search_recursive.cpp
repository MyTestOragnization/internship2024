#include <iostream>
#include <vector>

using namespace std;

int binarySearchRecursive(const vector<int> &arr, int target, int low, int high)
{
    if (low > high)
    {
        return -1; // Target not found
    }

    int mid = low + (high - low) / 2;

    if (arr[mid] == target)
    {
        return mid; // Target found
    }
    else if (arr[mid] < target)
    {
        return binarySearchRecursive(arr, target, mid + 1, high); // Search in the right half
    }
    else
    {
        return binarySearchRecursive(arr, target, low, mid - 1); // Search in the left half
    }
}

int main()
{
    vector<int> sortedList = {2, 3, 4, 10, 40};
    int target = 10;
    int result = binarySearchRecursive(sortedList, target, 0, sortedList.size() - 1);

    cout << endl
         << endl;

    if (result != -1)
    {
        cout << "Element found at index " << result << endl;
    }
    else
    {
        cout << "Element not found in the list" << endl;
    }

    return 0;
}
