#include <iostream>
#include <vector>
#include <queue>

using namespace std;

int findKthLargest(std::vector<int> &elements, int k)
{
    // Min-heap to store the k largest elements
    priority_queue<int, vector<int>, greater<int>> minHeap;

    for (int element : elements)
    {
        if (minHeap.size() < k)
        {
            minHeap.push(element);
        }
        else if (element > minHeap.top())
        {
            minHeap.pop();
            minHeap.push(element);
        }
    }

    // The root of the heap is the k-th largest element
    return minHeap.top();
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
