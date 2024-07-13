#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int findKthLargest(vector<int> &elements, int k)
{
    // Sort the elements in descending order
    sort(elements.begin(), elements.end(), greater<int>());

    // Return the k-th largest element (1-based index)
    return elements[k - 1];
}

int main()
{
    vector<int> elements = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};
    int k = 3;

    int kthLargest = findKthLargest(elements, k);

    cout << endl
         << endl
         << "The " << k << "-th largest element is: " << kthLargest << endl;

    return 0;
}
