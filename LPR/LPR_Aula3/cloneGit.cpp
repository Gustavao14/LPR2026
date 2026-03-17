#include <iostream>
#include <locale>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.utf8"); //Para usar acentuação
    cout << "\033[1;34m***************************************************\033[0m\n";
    cout << "\033[1;32m*                                                 *\033[0m\n";
    cout << "\033[1;32m*   \033[1;33m PARABÉNS 34DS!                     \033[1;32m          *\033[0m\n";
    cout << "\033[1;32m*   *\033[0m\n quanto cálculo";
    cout << "\033[1;32m*   \033[1;36m Você clonou um reinado público do Git     \033[1;32m*\033[0m\n";
    cout << "\033[1;32m*   \033[1;36m para o seu reinado local!                 \033[1;32m*\033[0m\n";
    cout << "\033[1;32m*                                                 *\033[0m\n";
    cout << "\033[1;34m***************************************************\033[0m\n";
        
    
 return 0;
}
