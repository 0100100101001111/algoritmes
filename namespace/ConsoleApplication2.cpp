#include <iostream>
//basic Namespace Usage. 
//For clarity, all in one file.
namespace firstNS 
{
    void Foo()
    {
        std::cout << "Foo firstNS" << std::endl;
    }
}

namespace secondNS
{
    void Foo()
    {
        std::cout << "Foo secondNS" << std::endl;
    }
}
// You can also use a joke in the form of namespace in namespace.)))
//МАТРЁШКА. Better not to use it as it looks funny. 

namespace thisNS 
{
    namespace secondNS
    {
        void Foo()
        {
            std::cout << "Foo thisNS" << std::endl;
        }
    }
}

int main()
{
    firstNS::Foo();
    secondNS::Foo();
    thisNS::secondNS::Foo();
    setlocale(LC_ALL, "ru");
}