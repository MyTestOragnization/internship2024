#include <iostream>
using namespace std;

    int factorial(int n){
        int res = 1;

        for(int i = 1 ; i <= n; i++ ){
            res *= i;
        }
        return res;
    }

int main() {
    int n;
    int fac;
    cout << " enter a number to factorize" << endl;
    cin >> n;

   fac = factorial(n);
   cout << fac;

    return 0;
}