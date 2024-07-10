#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

    void show_matrix(int** matrix, int rows)
    {
        for(int i=0; i < rows; i++){
            cout << endl;        
            for(int j=0; j < rows; j++){
                cout << matrix[i][j] <<"  ";
            }     
        }

    }



    int find_max(int** matrix, int rows){
        int max_val = 0;
        int j;
        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
                if(max_val < matrix[i][j]){
                    max_val = matrix[i][j];
                }    
            }
        }

        return max_val;
    }



    int find_min(int** matrix, int rows){
        int min_val = 100;
        int j;
        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
                if(min_val > matrix[i][j]){
                    min_val = matrix[i][j];
                }     
            }
        }

        return min_val;
    }


    int find_average(int** matrix, int rows){
        int average = 0;
        int sum = 0;

        int j;
        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
               sum += matrix[i][j] ;
            }
        }

        average = sum  / (rows * rows);

        return average;
    }



int main(){
    int rows;
    int max = 0 ;
    int min = 0;
    int** matrix;
    int average;
//    int matrix2[][3] = { {1,2,3}, {4,5,6},{1,1,1}};

    cout << "please enter the number of rows" << endl;
    cin>> rows;

    // Step 1: Allocate memory for the array of pointers
    matrix = new int*[rows];

    // Step 2: Allocate memory for each row
    for (int i = 0; i < rows; ++i) {
        matrix[i] = new int[rows];
    }

    cout << " THE MATRIX " << endl;

    // step 3 assign new value to particular cell of matirx
    // srand(time(NULL));
    for(int i=0; i < rows; i++){        
        for(int j=0; j < rows; j++){
            matrix[i][j] = (rand () % 99) + 1;
        }     
    }

    show_matrix(matrix, rows);

    cout << endl;
    max = find_max(matrix, rows);
    cout << "max: " << max << endl;

    min = find_min(matrix, rows);
    cout << "min: " << min << endl;

    average = find_average(matrix, rows);
    cout << "average: " << average << endl;
    return 0;
}


