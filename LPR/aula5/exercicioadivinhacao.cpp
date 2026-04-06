#include <iostream>
#include <random>

int main() {
    std::random_device numAleatorio;    // Seed source
    std::mt19937 gen(numAleatorio());   // Mersenne Twister engine
    std::uniform_int_distribution<> distribuicao(1, 100); // Range 1-100

    int valorAleatorio = distribuicao(gen); // Secret number
    int tentativa;

    std::cout << "Guess the number between 1 and 100: ";
    do {
        std::cin >> tentativa;
        if(tentativa < valorAleatorio) std::cout << "Higher!";
        else if(tentativa > valorAleatorio) std::cout << "Lower!";
        else std::cout << "Congratulations, you guessed it!"; 
    } while (tentativa != valorAleatorio);

    return 0;
}