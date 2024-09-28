#include <iostream>
using namespace std;
class clsPerson
{
public:
    virtual void Print()
    {
        cout << "Hi,I'm a person" << endl;
    }
};
class clsEmployee :public clsPerson
{
public:
    void Print()
    {
        cout << "Hi,I'm an Employee" << endl;
    }
};
class clsStudiant :public clsPerson
{
public:
    void Print()
    {
        cout << "Hi,I'm a Studiant" << endl;
    }
};
int main()
{
    clsEmployee Employee1;
    clsStudiant Studiant1;
    // Early-Static  Binding

    Employee1.Print();
    Studiant1.Print();

    clsPerson* Person1 = &Employee1;
    clsPerson* Person2 = &Studiant1;
    //Late-Dynamic  Binding
    Person1->Print();
    Person2->Print();

    return 0;
}