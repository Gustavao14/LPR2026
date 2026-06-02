#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main() {
    string algumascidades[4] = {"Vitoria", "Belo Horizonte", "Rio de Janeiro", "Sao Paulo"};
    int distancia [4] [4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };
    cout<< "Tabela de distancias (km) " << endl << endl;
    for (int i = 0; i < 4; i++){
        cout << algumascidades[i] << " para:" << endl;
        for ( int j = 0; j < 4; j++){
            cout << setw(15) << left << algumascidades[j] << distancia[i] [j] << "km" << endl;
        }
    }
    cout << endl;
    int origem = 0;
    int destino = 1;

    cout << "A distância entre" << algumascidades[origem] << " e " << algumascidades[destino] << "é de: ";
    cout << distancia [origem] [destino] << "km." << endl;

    return 0;
}