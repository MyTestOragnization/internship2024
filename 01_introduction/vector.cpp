#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

// array of numbers 2...30
auto getNumbers()
{
    vector<int> numbers{2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
    return numbers;
}

vector<int> findPrimeNumbers(vector<int> numbers)
{
    // array for prime numbers
    vector<int> primes{2};
    int index;
    // current divider
    int p = 2;
    // check if p in array of prime numbers
    vector<int>::iterator pInPrimes = std::find(numbers.begin(), numbers.end(), p);

    while (pInPrimes != primes.end())
    {
        for (int i : numbers)
        {
            pInPrimes = std::find(numbers.begin(), numbers.end(), i);
            if (pInPrimes != primes.end())
            {
                if (i % p == 0)
                {
                    numbers.erase(pInPrimes);
                }
            }
            else
            {
                p++;
            }
        }
        p++;
    }
    return primes;
}

int main()
{

    cout << endl;
    for (int i : findPrimeNumbers(getNumbers()))
    {
        cout << i << " ";
    }
}
