#include <iostream>
#include <map>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
     srand(static_cast<unsigned int>(time(0)));
    int save[2] = {0,0};
    map < int, int > mapa;
    int liczba;
    int n;
    cin>>n;
    int* tab = new int[n]; 
    for(int l = 0 ; l < 10 ; l++)
    {
    for(int i = 0 ; i < n ; i++)
    {
        tab[i] = rand() % 10;
      //  cout<<tab[i]<<"  ";
    }
    cout<<endl;

    for(int i = 0 ; i < n ; i++)
{
    mapa[tab[i]]++;
    // cout<<mapa[tab[i]]<<endl;
}

    for(int i = 0 ; i < 10 ; i++)
{
    if(save[0]<mapa[i])
    {
        save[0] = mapa[i];
        save[1] = i;
    }
}
    cout<<save[0]<<" "<<save[1];
    }


}