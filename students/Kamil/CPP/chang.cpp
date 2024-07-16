#include <iostream>
#include <math.h>
using namespace std;

void change(float cost)
{
    int tabval[15];
    int tab[15] = {50000,20000,10000,5000,2000,1000,500,200,100,50,20,10,5,2,1};
    int i = 0;
    cost *= 100;
    int cost1 = (int)(cost);
 
    while(cost1 > 0)
    {
        tabval[i] = cost1 / tab[i];
        cost1 = cost1 - tab[i]*tabval[i];
        if(tabval[i] != 0)
        {
            if(i<10)
            {
                cout<<endl<< "you get : "<<tabval[i]<<"--"<<tab[i]/100<<" zł";
            }else
            {
                cout<<endl<< "you get : "<<tabval[i]<<"--"<<tab[i]<<" groszy";
            }
        }
        i++;
    }
    
//                             1253.14
    
}

int main()
{
    float cost = 0;
    cout<<"How much it cost: ";
    cin>>cost;
    cout<<"thats's change : " ;
    change(cost);

    return 0;
}