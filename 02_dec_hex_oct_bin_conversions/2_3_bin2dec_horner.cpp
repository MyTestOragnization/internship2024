// Zastosowanie schematu Hornera przy obliczaniu
// wartości liczb zapisanych w różnych systemach
// pozycyjnych o podstawie p od 2 do 10
//----------------------------------------------
// (C)2005 mgr Jerzy Wałaszek
//                     I Liceum Ogólnokształcące
//                     im. K. Brodzińskiego
//                     w Tarnowie
//-----------------------------------------------
#include <iostream>
#include <string>

using namespace std;

main()
{
    string s;
    unsigned i, p, L, c;
    char z[1];

    cout.clear();

    cout << endl
         << endl
         << "Obliczanie wartosci liczby zapisanej\n"
            "w systemie pozycyjnym  o podstawie p\n"
            "    przy pomocy schematu Hornera\n"
            "------------------------------------\n"
            "(C)2005 mgr J. Walaszek  I LO Tarnow\n\n"
            "Podaj p (2..10) = ";
    cin >> p;
    cout << "\nPodaj liczbe    = ";
    getline(cin, s);
    getline(cin, s);
    L = s[0] - int('0');
    for (i = 1; i < s.length(); i++)
    {
        c = s[i] - int('0');
        L = L * p + c;
    }
    cout << "\nLiczba " << s << "(" << p << ") = " << L << "(10)"
                                                           "\n\nNacisnij ENTER...\n";
    cin.getline(z, 1);
}
