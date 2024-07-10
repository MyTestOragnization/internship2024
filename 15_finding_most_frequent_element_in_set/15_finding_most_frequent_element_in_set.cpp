#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

// Function to find the most frequent element in a set
int findMostFrequent(const vector<int> &elements)
{
    // Map to store the frequency of each element
    unordered_map<int, int> frequencyMap;

    // Count the frequency of each element
    for (int element : elements)
    {
        frequencyMap[element]++;
    }

    // Find the element with the highest frequency
    int mostFrequentElement = elements[0];
    int maxFrequency = frequencyMap[mostFrequentElement];

    for (const auto &pair : frequencyMap)
    {
        if (pair.second > maxFrequency)
        {
            mostFrequentElement = pair.first;
            maxFrequency = pair.second;
        }
    }

    return mostFrequentElement;
}

int main()
{
    vector<int> elements = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5};

    int mostFrequent = findMostFrequent(elements);

    cout.clear();
    cout << endl
         << endl
         << "The most frequent element is: " << mostFrequent << endl;

    return 0;
}
