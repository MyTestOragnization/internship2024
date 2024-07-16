#include <iostream>
using namespace std;


int GCD(int a, int b)
{
    int r = 1;
    if(a == b)
    {
        return a;
    }
    while(r != 0)
    {
        if(a>b)
        {
            r = a % b;
            if(r != 0)
            {
                a = r;
            }
            return a;
        }else
        {
            r = b % a;
            if(r != 0)
            {
                b= r;
            }else
            {
                return b;
            }
        }
    } 
}
LCM(int a, int b )
{
    return (a * b) / GCD(a,b);
}

int main()
{
    int a , b;
    cin>>a>>b;
    cout<<GCD(a,b)<<endl<<LCM(a,b);
    
    return 0;
}