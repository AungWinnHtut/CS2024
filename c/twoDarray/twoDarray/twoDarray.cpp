#include <iostream>
#include<array>
using namespace std;
int main() {
    
    const int rows = 3;
    const int cols = 4;
    const int temp_rows = cols;
    const int temp_cols = rows;
    array<int, 10> testarray;

    int testarray1[10];
    int temp[temp_rows][temp_cols] = {0};
    int matrix[rows][cols] = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    };
    
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            temp[c][r] = matrix[r][c];
        }
    }

    cout << endl << "original array" << endl;
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            cout << "   " << matrix[r][c] << "   ";
        }
        cout << endl;
    }

    cout << endl << "trnsported array" << endl;

    for (int r = 0; r < temp_rows; r++)
    {
        for (int c = 0; c < temp_cols; c++)
        {
            cout << "   "<<temp[r][c] << "   ";
        }
        cout << endl;
    }

    return 0;
}
