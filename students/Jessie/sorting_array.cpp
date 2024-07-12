#include <iostream>
using namespace std;

void show_arr(int arr[10], int n)
{
     for(int i = 0; i < n; i++){
        cout << arr[i] << "  ";
     }
}

    void sorting (int arr[10], int n){
        int temp;
        for (int i = 0; i < n; i++){
            for (int j = i +1; j < n; j++ ){
                if(arr[i] > arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }


int main(){
    int arr[10];
    int n = 10;

    srand(time(NULL));
    for(int i = 0; i < n; i++){
        arr[i] = (rand () % 100);
//        cout << "  "  << arr[i];
    }

    cout.clear();
    cout << endl << endl;
    
    show_arr(arr, n);
    
    sorting(arr, n);
    
    cout << endl << endl;

    show_arr(arr, n);

    return 0;
}