#include <iostream>
#include <string>
using namespace std;
int main () {
    int multiplica = 0;
    int A[3][3], B[3][3];
    cout << "Digite 9 numeros inteiros" << endl;
    for ( int i = 0; i < 3; i++ ) {
        for( int j = 0; j < 3; j++) {
            cout << "A[" << i << "]" <<"[" << j << "]";
            cin >> A[i] [j];
        }
        cout << endl;
    }
    
    cout << "Digite 9 numeros inteiros" << endl;
    
    for ( int i = 0; i < 3; i++ ) {
        for( int j = 0; j < 3; j++) {
            cout << "B[" << i << "]" <<"[" << j << "]";
            cin >> B[i][j];
        }
        cout << endl;
    }
     for ( int i = 0; i < 3; i++ ) {
        for( int j = 0; j < 3; j++) {
            multiplica = A[i][j] * B[j][i];
        }
     }
    cout << multiplica << endl;
    return 0;
}