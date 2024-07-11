#include <iostream>
#include <bits/stdc++.h>
using namespace std;

    void sieveOfErat(int num){
        int p;
        bool prime[num + 1];
        memset(prime, true, sizeof(prime));
        for (int p = 2; p * p <= num; p++) {

        if (prime[p] == true) {
            for (int i = p * p; i <= num; i += p)
                prime[i] = false;
        }
    }

     cout << endl;
    // Print the all prime numbers.
    for (int p = 2; p <= num; p++){
    
        if (prime[p])
            cout << " " << p << " ";
        }
}
    

int main(){
    int num, prime=2;
    int arr[num];
    cout << "enter the max value of the prime numbers range" << endl;
    cin >> num;

    for(int i = 1; i <= num; ++i) {
        arr[num] = i + 1; 
        cout << arr[num] << " "; }

    sieveOfErat(num);

    return 0;
}