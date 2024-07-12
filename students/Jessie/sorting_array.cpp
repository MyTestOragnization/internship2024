#include <iostream>
using namespace std;

    void sorting (int arr[10], int n = 10 ){
        int temp;
        for (int i = 0; i < n; i++){
            for (int j = i +1; j < n; j++ ){
                if(arr[i] > arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                   
                }
            }
            cout << arr[i] << "  ";
        }
    }


int main(){
    int arr[10];
    int n = 10;
    srand(time(NULL));
    for(int i = 0; i < n; i++){
        arr[i] = (rand () % 100);
        cout << "  "  << arr[i];
    }

    cout << endl;

    sorting(arr, n );

    return 0;
}