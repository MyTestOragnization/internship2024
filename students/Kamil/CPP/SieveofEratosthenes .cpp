#include <iostream>
#include <string>
#include <math.h>
using namespace std;


void prime(int n)
{
    bool c = true;
    int m = 2;
    int* tab = new int[n +1];
    bool* tabB = new bool[n + 1];
    for(int i = 0 ; i < n + 1 ; i++)
    {
        tabB[i] = true;
        tab[i] = i;
        
        
    }
    for(int i = 2 ; i < n +2 ; i++)
    {
        while(c == true)
        {
            if(tab[i] * m < n + 1)
            {
                tabB[tab[i]*m] = false;
            }else
            {
                c = false;
            }
            m++;
        }
        c = true;
        m = 2;
    }
    for(int i = 0 ; i < n + 1 ; i++)
    {
        if(tabB[i] == true)
        {
            cout<<tab[i]<<"     ";
        }
    }

}



int main()
{
    int n = 0;
    cin>>n;
    prime(n);
    return 0;
}