#include <iostream>
using namespace std;

    int factorial2(int n){
        //  if(n <= 1){
        //     return 1;
        //  }
        //  else
        return n <= 1 ? 1 : n * factorial2( n - 1);
    
        }


int main() {
    int n;
    int fac;
    cout << " enter a number" << endl;
    cin >> n;

   fac = factorial2(n);
   cout << fac;

    return 0;
}