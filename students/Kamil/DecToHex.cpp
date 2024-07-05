#include <iostream>
#include <stdlib.h>
#include <string.h>
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

int main()
{
    string dec;
    cin>>dec;
    
    cout<<DecToHex(dec);

    return 0;
}