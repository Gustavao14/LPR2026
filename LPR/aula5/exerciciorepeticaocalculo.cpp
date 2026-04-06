#include <iostream>
using namespace std;

// Função para calcular a soma dos dígitos de um número
int somaDigitos(int n) {
    int soma = 0;
    while (n > 0) {
        soma += n % 10; // extrai o último dígito e adiciona à soma
        n /= 10;        // remove o último dígito
    }
    return soma;
}

int main() {
    int numero;
    char continuar;

    do {
        cout << "Digite um número inteiro: ";
        cin >> numero;

        int quadrado = numero * numero;
        int soma = somaDigitos(quadrado);

        cout << "O quadrado de " << numero << " é " << quadrado << endl;
        cout << "A soma dos dígitos de " << quadrado << " é " << soma << endl;

        cout << "Deseja continuar? (s/n): ";
        cin >> continuar;

    } while (continuar == 's' || continuar == 'S');

    cout << "Programa encerrado." << endl;
    return 0;
}