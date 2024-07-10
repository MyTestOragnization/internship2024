// algorytm.edu.pl
#include <iostream>
using namespace std;

int gcd(int a, int b)
{
    while (a != b)
        if (a > b)
            a -= b; // lub a = a - b;
        else
            b -= a; // lub b = b-a
    return a;       // lub b - both variables store the result of GCD(a,b)
}

int main()
{
    int a, b;

    cout.clear();
    cout << endl
         << "Input 2 numbers: ";
    cin >> a >> b;

    cout << "GCD (" << a << "," << b << ") = " << gcd(a, b) << endl;

    return 0;
}