/*
#include <iostream>
#include <string>

using namespace std;

class IBicycle  //интерфейс
{
    public:
        void virtual TwistTheWheel() = 0;
        void virtual Ride() = 0;

};

class SimpleBicycle : public IBicycle //Класс который реализовывает интерфейс 
{
    public: void TwistTheWheel() override 
    {
        cout << "метод TwistTheWheel SimpleBicycle" << endl;
    }

    void Ride() override 
    {
        cout << "метод Ride() SimpleBicycle " << endl;
    }
};

class SportBicycle : public IBicycle
{
public: void TwistTheWheel() override
{
    cout << "метод TwistTheWheel SportBicycle" << endl;
}

      void Ride() override
      {
          cout << "метод Ride() SportBicycle " << endl;
      }
};

class Human
{
public:
    void RideOn(IBicycle& bicycle)
    {
        cout << "Крутим руль" << endl;
        bicycle.TwistTheWheel();
        cout << endl << "Поехали" << endl;
        bicycle.Ride();
    }
};

int main()
{
    setlocale(LC_ALL, "ru");
    SimpleBicycle sb;
    SportBicycle sportB;
    
    Human h;
    h.RideOn(sportB);

    return 0;
}






#include <iostream>

using namespace std;

int main()
{
    int size, a = 1;

    cin >> size;

    for (int i = 0; i < size; ++i)
    {
        for (int j = 0; j < size * 2; ++j)
        {
            if (j < size && j < a || j >= size && j >= size * 2 - a)
                cout << '*';
            else
                cout << ' ';
        }

        if (i < size / 2)
            a += 2;
        else
            a -= 2;

        cout << endl;
    }

    system("pause");
    return 0;
}
*/

#include <iostream>
//#include <string>
#include <iomanip>

using namespace std;

int treagle(int n)
{
    int m = (n + 1) / 2;
    char field = ' ';
    for (int i = 1; i <= m; i++)
    {
        for (int j = 0; j <= 1; j++) {
            cout.fill(' ');
            cout << setw(m - i + 1) << field;
            cout.fill('*');
            cout << setw(i + 1) << '\n';
        }

        return 1;
    }
}

int main()
{
    setlocale(LC_ALL, "ru");
    int n;
    for (;;)
    {
        cout << "Введите размер основания n(нечётное):" << endl; cin >> n;
        if (n == 0 || n % 2 == 0) { treagle(n); }
        else { cout << "Введите нечётное число" << endl; }
    }
    return 0;
}
