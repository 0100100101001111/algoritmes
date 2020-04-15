#include <iostream>
void main(){
    double  z1, z2, a;
        std::cout << "Enter value a ="; std::cin >> a;
        if (a == 0 || a == 2 || a == -2) {
            std::cout << "Try it again" << std::endl;}
        else {
            z1 = 1 /((1 + a + a * a) / (2 * a + a * a) + 2 - (1 - a + a * a) / (2 * a - a * a)) * (5 - 2 * a * a);
            z2 = (4 - a * a) / 2;
            std::cout << z1 << "=" << z2 << std::endl;}
    system("pause");}