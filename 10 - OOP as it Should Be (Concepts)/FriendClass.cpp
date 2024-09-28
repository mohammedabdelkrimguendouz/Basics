#include <iostream>
using namespace std;

class clsA
{
private:
    int _Var1;
protected:
    int _Var3;
public:
    int Var2;
    clsA()
    {
        _Var1 = 10;
        Var2 = 20;
        _Var3 = 30;
    }
    friend class clsB; // الكلاس clsB اصبح صديق clsA ويصل الى جميع الامور الخاصة والعامة والمحمية 
};
class clsB
{
public:
    void Display(clsA A1)
    {
        cout << "Value of _var1 = " << A1._Var1<<endl;
        cout << "Value of var2 = " << A1.Var2 << endl;
        cout << "Value of _var3 = " << A1._Var3 << endl;
    }
};

int main()
{
    clsB B1;
    clsA A1;
    B1.Display(A1);
    return 0;
}