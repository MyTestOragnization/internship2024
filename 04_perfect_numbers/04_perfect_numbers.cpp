// algorytm.edu.pl
#include <iostream>
#include <cmath>
using namespace std;

bool czy_doskonala(int n)
{
    int s = 1, p = sqrt(n);
    for (int i = 2; i <= p; i++)
        if (n % i == 0)
            // dodajemy do sumy dwa dzielniki
            s += i + n / i;

    // jesli mamy do czynienia z liczbą kwadratową
    // to dwa razy dodalismy jej pierwiastek
    // więc musimy go raz odjąć
    if (n == p * p)
        s -= p;

    // jesli suma dzielników jest równa danej liczbie
    // do podana liczba jest doskonała
    if (n == s)
        return 1;

    return 0;
}

int main()
{
    int n;
    cout << "Podaj liczbę: ";

    cin >> n;

    if (czy_doskonala(n))
        cout << "Liczba " << n << " jest doskonała";
    else
        cout << "Liczba " << n << " nie jest doskonała";

    return 0;
}