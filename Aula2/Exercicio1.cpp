#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double raio, area;
 const double PI = 3.14159;
    cin >> raio;
    area = PI * raio * raio;
    cout << fixed << setprecision(4) << area << endl;
    return 0;
}   
