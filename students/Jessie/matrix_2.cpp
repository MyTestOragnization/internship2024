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
        int summary = 0;

        int j;
        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
               summary += matrix[i][j] ;
            }
        }

        average = summary  / (rows * rows);

        return average;
    }

    int diagonal_sumLR(int** matrix, int rows ){
        int diagonals;
        int sum;

        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
              if(i == j){
              diagonals = matrix[i][j];
              sum += diagonals;
              }
            }
        }

    return sum;
    }

    int diagonal_sumRL(int** matrix, int rows ){
        int diagonals;
        int sum;

        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
              if((i + j) == (rows - 1)){
                diagonals = matrix[i][j];
                sum += diagonals;
              }
            }
        }
    return sum;
    }

    int diag_max(int** matrix, int rows){
      int diagonals;
        int diag_max = 0;

        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
              if((i + j) <= (rows - 1)){
            diagonals = matrix[i][j];
          
                if(diag_max < diagonals){
                    diag_max = diagonals;
                }
              }
            }
        }

    return diag_max;  
    }

        int diag_min(int** matrix, int rows){
      int diagonals;
        int diag_min = 100;

        for(int i=0; i < rows; i++){
            for(int j=0; j < rows; j++){
              if((i + j) >= (rows - 1)){
            diagonals = matrix[i][j];
          
                if(diag_min > diagonals){
                    diag_min = diagonals;
                }
              }
            }
        }

    return diag_min;  
    }

int main(){
    int rows;
    int max = 0, min = 0, average;
    int** matrix;
    int sumLR, sumRL, dmax,dmin;

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
    srand(time(NULL));
    for(int i=0; i < rows; i++){        
        for(int j=0; j < rows; j++){
            matrix[i][j] = (rand () % 100);
        }     
    }

    // funztions: 

    show_matrix(matrix, rows);

    cout << endl;

    max = find_max(matrix, rows);
    cout << "max: " << max << endl;

    min = find_min(matrix, rows);
    cout << "min: " << min << endl;

    average = find_average(matrix, rows);
    cout << "average: " << average << endl;

    sumLR = diagonal_sumLR(matrix, rows);
    cout << "sum of the diagonal left to right: " << sumLR << endl;

    sumRL = diagonal_sumRL(matrix, rows);
    cout << "sum of the diagonal right to left: " << sumRL << endl;

    dmax = diag_max(matrix, rows);
    cout << "max of the left part of matrix: " << dmax << endl;

    dmin = diag_min(matrix, rows);
    cout << "min of the left part of matrix: " << dmin << endl;


    return 0;
}


