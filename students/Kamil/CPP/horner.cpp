#include <iostream>
using namespace std;


int hexToDecEz(string hex)
{
        int len = hex.length(), res = 0;
    int* tab = new int[hex.length()];

       for (int i = 0 ; i < len ; i++) {
        if (hex[i] >= '0' && hex[i] <= '9') {
            tab[i] = hex[i] - '0';
        } else if (hex[i] >= 'A' && hex[i] <= 'F') {
            tab[i] = hex[i] - 'A' + 10;
        } else if (hex[i] >= 'a' && hex[i] <= 'f') {
            tab[i] = hex[i] - 'a' + 10;
        }
       // cout<<endl<<tab[i];
    }

    for(int i = 0; i < len - 1; i++)
    {
        if(i == 0)
        {
            res = tab[i] * 16 + tab[i+1]; 
        }else
        {
            res = res * 16 + tab[i+1];
        }
    }

    return res;
}


int main()
{
    string hex;
    cin>>hex;
    cout<<hexToDecEz(hex);
    return 0;
}