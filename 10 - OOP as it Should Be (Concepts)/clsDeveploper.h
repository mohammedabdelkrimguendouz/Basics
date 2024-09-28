#pragma once

#include <iostream>
#include "clsEmployee.h";
using namespace std;


class clsDeveloper :public clsEmployee
{
private:
    string _MainProgrammingLanguage;
public:
    clsDeveloper(int ID, string FirstName, string LastName, string Email, string Phone, string Title, string Departement, float Salary, string MainProgrammingLanguage)
        :clsEmployee(ID, FirstName, LastName, Email, Phone, Title, Departement, Salary)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }
    void SetMainProgrammingLanguage(string MainProgrammingLanguage)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }
    string MainProgrammingLanguage()
    {
        return _MainProgrammingLanguage;
    }

    void Print()
    {
        cout << "Info : \n";
        cout << "_________________________________\n";
        cout << "ID          : " << ID() << endl;
        cout << "FirdtName   : " << FirstName() << endl;
        cout << "LastName    : " << LastName() << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;
        cout << "Title       : " << Title() << endl;
        cout << "Departement : " << Department() << endl;
        cout << "Salary      : " << Salary() << endl;
        cout << "PLanguage   : " << _MainProgrammingLanguage << endl;
        cout << "_________________________________\n";
    }
};

