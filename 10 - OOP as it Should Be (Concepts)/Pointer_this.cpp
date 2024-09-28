#include <iostream>
using namespace std;

class clsEmployee
{
public:
    int ID;
    string Name;
    float Salary;
    clsEmployee(int ID, string Name, float Salary)
    {
        this->ID = ID;
        this->Name = Name;
        this->Salary = Salary;
    }
    static void Func1(clsEmployee Employee1)
    {
        Employee1.Print();
    }
    void Func2()
    {
        Func1(*this);
    }

    void Print()
    {
        cout << ID << "  " << Name << "  " << Salary<<endl;
    }
};


int main()
{ 
    clsEmployee Employee1(10,"karim",5000);
    Employee1.Print();
    Employee1.Func2();
    return 0;
}
