// algorytm.edu.pl
#include <iostream>
using namespace std;

long long quick_pow(long long a, unsigned int n)
{
    if (n == 0)
        return 1;

    if (n % 2 == 1) // gdy n jest nieparzyste
        return a * quick_pow(a, n - 1);

    // żeby dwa razy nie wchodzić w tą samą rekurencję
    long long w = quick_pow(a, n / 2);
    return w * w;
}

int main()
{
    unsigned int n;
    long long a;

    cout.clear();

    cout << endl
         << endl
         << "Base: ";
    cin >> a;
    cout << "Power: ";
    cin >> n;

    cout << a << " to power of " << n << " equal " << quick_pow(a, n);

    return 0;
}