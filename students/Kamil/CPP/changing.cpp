#include <iostream>
#include <string>
#include <math.h>
using namespace std;

string DecToHex(string dec)
{
    string hex;
    int decInInt = stoi(dec);
    int* hexInt = new int[dec.length()];
    int l = -1;
    char hexTab[16] = {'0','1','2','3','4','5','6','7','8','9','A','b','C','d','E','F'};
    while(decInInt>0)
    {
        l++;
        hexInt[l] = decInInt % 16;
        decInInt = decInInt / 16;
    }
    for(int i = l  ; i >= 0; i--)
    {
        hex += hexTab[hexInt[i]];
    }




    return hex;
}

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






int hexToDec(string hex)
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


for(int i = 0 ; i < len  ; i++)
{

    tab[i] = tab[i] * pow(16,len-i-1);
    res += tab[i];
}



    return res;
}

int main()
{
    string hex;
    string dec;
    cin>>hex;
    cout.clear();
    cout<<hexToDec(hex);
    cout<<endl<<hexToDecEz(hex)<<endl;
    cin>>dec;
    cout<<endl<<DecToHex(dec);

    return 0;
}
