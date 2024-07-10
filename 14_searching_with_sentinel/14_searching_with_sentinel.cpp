#include <iostream>
#include <vector>

using namespace std;

// Function to perform sentinel search
bool sentinelSearch(vector<int> &arr, int target)
{
    int n = arr.size();

    // Append the target as a sentinel
    arr.push_back(target);

    // Perform linear search
    int i = 0;
    while (arr[i] != target)
    {
        ++i;
    }

    // Remove the sentinel
    arr.pop_back();

    // If we found the target before reaching the sentinel, return true
    return (i < n);
}

int main()
{
    vector<int> arr = {3, 1, 4, 1, 5, 9, 2, 6};
    int target = 5;
    cout.clear();
    cout << endl
         << endl;

    if (sentinelSearch(arr, target))
    {
        cout << "Element " << target << " found in the array." << std::endl;
    }
    else
    {
        cout << "Element " << target << " not found in the array." << std::endl;
    }

    return 0;
}
