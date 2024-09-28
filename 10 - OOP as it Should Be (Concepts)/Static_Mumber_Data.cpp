#include <iostream>
using namespace std;

class clsA
{
public:
    int var;
    static int Counter; // جميع الكائنات تشترك في هذا المتغير اي مكان واحد في الرام 
                        // عند التعديل عليه يتغير بالنسية لجميع الكائنات
    clsA()
    {
        Counter++;
    }
    void Print()
    {
        cout << "var : " << var << endl;
        cout << "Counter : " << Counter << endl;
    }
};

int clsA::Counter = 0;

int main()
{

    clsA A1, A2, A3;
    A1.var=10;
    A2.var=20;
    A3.var=30;
    A1.Print();
    A2.Print();
    A3.Print();

    A1.Counter = 500;

    A1.Print();
    A2.Print();
    A3.Print();
    return 0;
}

