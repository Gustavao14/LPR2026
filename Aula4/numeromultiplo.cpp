#include <iostream>
using namespace std;
int main() {
int A, B;
// Leitura dos dois valores inteiros
cin >> A >> B;
// Verifica se A é múltiplo de B ou B é múltiplo de A
if (A % B == 0 || B % A == 0) {
cout << "Sao Multiplos" << endl;
} else {
cout << "Nao sao Multiplos" << endl;
}
return 0;
}
