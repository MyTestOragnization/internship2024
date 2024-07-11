#include <iostream>
using namespace std;

    // void sorting(int num[10], int n = 10 ){
    //     int temp;
    //     int j;

    //             }
    //         } 
    //    }


      
    // }


int main(){
        int num[10];
        int n = 10;
      int sorted,temp;
        for(int i=0; i<10; i++){
            num[i] =(rand () % 99) + 1;
            cout << num[i] <<"  ";
        }

cout << endl;
    for (int i = 0; i < 10; i++){
    	for (int j = 1; j < 10; j++ ){
                if(num[i] < num[j]){
                    temp = num[i];
    	            num[i] = num[j];
                	num[j] = temp;
                    cout << num[i] << "  ";
                }
        }
    }

        // sorting(num );
        // cout << "sorted array: " << sorted << "  ";


    return 0;
}