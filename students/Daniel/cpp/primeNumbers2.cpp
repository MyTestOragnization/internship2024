#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

// array of numbers 2...30
auto getNumbers()
{
    vector<int> numbers;
    for (int insertNumbers = 2; insertNumbers <= 50; insertNumbers++)
    {
        numbers.push_back(insertNumbers);
    }
    return numbers;
}

vector<int> copy_vector(vector<int> original)
{
    vector<int> res;
    for (int i : original)
        res.push_back(i);

    return res;
}

vector<int> findPrimeNumbers(vector<int> numbers)
{
    int maxVal = numbers.back();
    vector<int> temparray = copy_vector(numbers);
    int currItem = temparray.at(0);
    for (int i = 0; i < numbers.size(); ++i)
    {
        currItem = numbers.at(i);
        // check if divider is prime
        if (find(temparray.begin(), temparray.end(), currItem) != temparray.end())
        {
            for (int next = currItem * currItem; next <= maxVal; next += currItem)
                temparray.erase(remove(temparray.begin(), temparray.end(), next), temparray.end());
        }
    }

    return temparray;
}

int main()
{

    cout << endl;
    for (int i : findPrimeNumbers(getNumbers()))
    {
        cout << i << " ";
    }
}
