#include <iostream>

using namespace std;
int main() {
    int soma = 0;
    int numeros [3][3];
    cout << "Digite 9 numeros inteiros" << endl;
      for ( int i = 0; i < 3; i++ ) {
            for( int j = 0; j < 3; j++) {
             cout << "numeros[" << i << "]" <<"[" << j << "]";
             cin >> numeros[i][j];
            }
        }
    for  (int i = 0; i < 3; i++ ) {
            for( int j = 0; j < 3; j++) {
                cout << "[" << numeros[i][j] << "]" ;
                soma += numeros[i][j];
            }
            cout << endl;
        }
        cout << " A soma e:" << soma << endl;
}