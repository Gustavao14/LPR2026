#include <iostream>
using namespace std;
int reverterInteiro(int n) {
    int numreverso = 0;
    
    while (n != 0) {
        int ultimoDigito = n % 10;
        numreverso = (numreverso * 10) + ultimoDigito;
        n /= 10;
    }
    
    return numreverso;
}

int main() {
    int num = 1234;
    cout << "Original: " << num << " | Reverso: " << reverterInteiro(num);
    return 0;
}
