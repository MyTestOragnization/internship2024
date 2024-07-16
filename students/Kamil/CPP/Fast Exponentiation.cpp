#include <iostream>
using namespace std;



int A(int p)
{
    return p*=p;
}
int B(int p, int d)
{
    return p*d;
}



int squer(int p, int g, int d , char* tab)
{
    int help = 0;
    while(tab[help] != 'C')
    {
        if(g == 2 )
        {
            tab[help] = 'A';
            tab[help + 1] = 'C';
            help++;
        }else if(g % 2 == 0)
        {
            g = g /2;
            tab[help] = 'A';
            help++;
        }else
        {
            g--;
            tab[help] = 'B';
            help++;
        }
    }

    for(int i = help ; i >= 0 ; i--)
    {
        if( tab[i] == 'A')
        {
           p = A(p);
        }else if(tab[i] == 'B')
        {
           p = B(p,d);
        }
    }

    return p;
}


int main()
{
    int p , g , d;
    cin>>p;
    cin>>g;
    d = p;
    char* tab = new char[g + 1];
    p = squer(p,g,d, tab);
    cout<<p;
    return 0;
}




