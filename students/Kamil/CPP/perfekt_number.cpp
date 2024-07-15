#include <iostream>
using namespace std;


bool isPrefect(int a)
{
    int help;
    for(int i = 1 ; i <= a/2; i++)
    {
        if(a%i == 0)
        {
            help += i;
        }
    }
    if(help == a)
    {
        return true;
    }else
    {
        return false;
    }

}


int main()
{
    int a;
    cin>>a;
    cout<<isPrefect(a);
}