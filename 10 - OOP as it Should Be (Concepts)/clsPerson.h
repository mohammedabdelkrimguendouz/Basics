#pragma once

#include <iostream>
using namespace std;


class clsPerson
{
private:
    int _ID;
    string _FirstName;
    string _LastName;
    string _Email;
    string _Phone;
public:
    clsPerson(int ID, string FirstName, string LastName, string Email, string Phone)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Email = Email;
        _Phone = Phone;
    }
    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }
    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }
    void SetEmail(string Email)
    {
        _Email = Email;
    }
    void SetPhone(string Phone)
    {
        _Phone = Phone;
    }
    int ID()
    {
        return _ID;
    }
    string FullName()
    {
        return _FirstName + " " + _LastName;
    }
    string FirstName()
    {
        return  _FirstName;
    }
    string LastName()
    {
        return _LastName;
    }
    string  Email()
    {
        return _Email;
    }
    string Phone()
    {
        return _Phone;
    }
    void SendEmail(string Subject, string Body)
    {
        cout << "\nThe flowwing message sent successfully to email : " << _Email << endl;
        cout << "Subject : " << Subject << endl;
        cout << "Body : " << Body << endl;
    }
    void SendSMS(string TextMessage)
    {
        cout << "\nThe flowwing SMS sent successfully to phone : " << _Phone << endl;
        cout << "SMS : " << TextMessage << endl;
    }
    void Print()
    {
        cout << "Info : \n";
        cout << "_________________________________\n";
        cout << "ID        : " << _ID << endl;
        cout << "FirdtName : " << _FirstName << endl;
        cout << "LastName  : " << _LastName << endl;
        cout << "FullName  : " << FullName() << endl;
        cout << "Email     : " << _Email << endl;
        cout << "Phone     : " << _Phone << endl;
        cout << "_________________________________\n";
    }


};
