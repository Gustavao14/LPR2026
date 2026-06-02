#include <iostream>

using namespace std;
int main() {
    int A[3] [3], B[3] [3], C[3] [3];
    cout << " Digite os elementos da matriz A (3x3)" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << "A[" << i << "]" <<"[" << j << "]";
            cin >> A[i] [j];
        } 
    }
    cout << endl;

    cout << "Digite os elementos da matriz B (3x3)" << endl;
    for (int i = 0; i < 3; i++) {
      for (int j = 0; j < 3; j++) {
        cout << "B[" << i << "]" "[" << j << "]";
        cin >> B[i] [j];
      }
    }
    for ( int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++){
            cout << C[i][j] << "\t"; //\t é para dar espaçamento
        }
        cout << endl;
    }
    return 0;
} 