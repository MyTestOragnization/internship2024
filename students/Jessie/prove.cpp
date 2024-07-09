#include <iostream>
#include <cstdlib> // for rand() and srand()
#include <ctime>   // for time()
using namespace std;

int main() {
    int n; // number of rows (and columns)

    // Ask the user for the number of rows (and columns)
    cout << "Enter the number of rows (and columns): ";
    cin >> n;

    // Create a dynamic 2D array
    int **matrix = new int*[n];
    for (int i = 0; i < n; ++i) {
        matrix[i] = new int[n];
    }

    // Seed the random number generator
    srand(static_cast<unsigned>(time(0)));

    // Fill the matrix with random numbers and print it
    cout << "Matrix filled with random numbers:" << endl;
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            matrix[i][j] = (rand() % 99) + 1; // random number between 1 and 99
            cout << matrix[i][j] << "  ";
        }
        cout << endl;
    }

    // Find the maximum value in the matrix
    int max = matrix[0][0];
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            if (matrix[i][j] > max) {
                max = matrix[i][j];
            }
        }
    }

    cout << "Max: " << max << endl;

  
    return 0;
}
