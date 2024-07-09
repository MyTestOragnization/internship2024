#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;


int main(){
    int row;
    int num[row];
    int i, j;
    

    cout << "please enter the number of rows" << endl;
    cin>> row;

    cout << " THE MATRIX " << endl;

    // srand(time(NULL));
    for(int i=0; i<row; i++){

        cout << endl;
        
        for(int j=1; j<=row; j++){
            num[i] =(rand () % 99) + 1;
            cout << num[i] <<"  ";
        }     
    }

    int max=num[0];
    for(i=0; i<row; i++){
       if(max < num[i])
			max = num[i];
}
    
cout << "max: " << max << endl;



// cout << "max: " << max << endl
// for(int i=0; i<row; i++){
//     cout << endl;
//     for(int j=1; j<=row; j++){
//      int num = (rand() % 99) +1 ;
//         cout << num << "  ";
//     }  //cout <<"max:" << maximum(num, row) << endl;
// }
                
     
     

    return 0;
}

//  int matrix[10][10] = {
//         {1, 2},
//         {3, 4},
//         {5, 6}
//     };

//     cout << matrix[0][1] << endl;
