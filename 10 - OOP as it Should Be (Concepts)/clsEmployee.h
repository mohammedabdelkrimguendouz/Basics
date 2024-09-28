#pragma once

#include <iostream>
#include "clsPerson.h";
using namespace std;

class clsEmployee :public clsPerson
{
private:
    string _Title;
    string _Department;
    float _Salary;
public:
    clsEmployee(int ID, string FirstName, string LastName, string Email, string Phone, string Title, string Department, float Salary)
        :clsPerson(ID, FirstName, LastName, Email, Phone)
    {
        _Title = Title;
        _Department = Department;
        _Salary = Salary;
    }
    void SetTitle(string Title)
    {
        _Title = Title;
    }
    void SetSalary(float Salary)
    {
        _Salary = Salary;
    }
    void SetDepartment(string Department)
    {
        _Department = Department;
    }
    string Title()
    {
        return _Title;
    }
    float Salary()
    {
        return _Salary;
    }
    string Department()
    {
        return _Department;
    }
    void Print()
    {
        // clsPerson::Print(); الوصول الئ الدالة في الكلاس الاب مباشرة
         // BaseClass::FunctionName();
        cout << "Info : \n";
        cout << "_________________________________\n";
        cout << "ID          : " << ID() << endl;
        cout << "FirdtName   : " << FirstName() << endl;
        cout << "LastName    : " << LastName() << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;
        cout << "Title       : " << _Title << endl;
        cout << "Departement : " << _Department << endl;
        cout << "Salary      : " << _Salary << endl;
        cout << "_________________________________\n";
    }
};

