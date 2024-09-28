
#include <iostream>
using namespace std;
class clsA
{
public:
    static int Fun1() // دالة حاصة يالكلاس وليس بالكائن// يمكن استدعائها من دون اوبجكت
    {
        return 10;
    }
    int Fun2()
    {
        return 20;
    }
};



int main()
{
    cout << clsA::Fun1() << endl;
    clsA A1, A2, A3;
    cout << A1.Fun1()<<endl;
    cout << A1.Fun2() << endl;
    cout << A2.Fun1() << endl;
    cout << A2.Fun2() << endl;

    return 0;
}

