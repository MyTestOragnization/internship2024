#include <iostream>
#include <vector>

using namespace std;

int binarySearch(const vector<int> &arr, int target)
{
    int low = 0;
    int high = arr.size() - 1;

    while (low <= high)
    {
        int mid = low + (high - low) / 2;

        if (arr[mid] == target)
        {
            return mid; // Target found
        }
        else if (arr[mid] < target)
        {
            low = mid + 1; // Search in the right half
        }
        else
        {
            high = mid - 1; // Search in the left half
        }
    }

    return -1; // Target not found
}

int main()
{
    vector<int> sortedList = {2, 3, 4, 10, 40};
    int target = 10;
    int result = binarySearch(sortedList, target);

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
