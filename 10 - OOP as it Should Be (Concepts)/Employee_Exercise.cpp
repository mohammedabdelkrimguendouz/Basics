#include <iostream>
using namespace std;
class clsEmployee
{
private:
    int _ID;
    string _FirstName;
    string _LastName;
    string _Title;
    string _Email;
    string _Phone;
    float _Salary;
    string _Department;
public:
    clsEmployee(int ID, string FirstName, string LastName,string Title, string Email, string Phone,float Salary,string Department)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Title = Title;
        _Email = Email;
        _Phone = Phone;
        _Salary = Salary;
        _Department = Department;
    }
    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }
    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }
    void SetTitle(string Title)
    {
        _Title = Title;
    }
    void SetEmail(string Email)
    {
        _Email = Email;
    }
    void SetPhone(string Phone)
    {
        _Phone = Phone;
    }
    void SetSalary(float Salary)
    {
        _Salary = Salary;
    }
    void SetDepartment(string Department)
    {
        _Department = Department;
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
        cout << "ID          : " << _ID << endl;
        cout << "FirdtName   : " << _FirstName << endl;
        cout << "LastName    : " << _LastName << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Title       : " <<_Title<< endl;
        cout << "Email       : " << _Email << endl;
        cout << "Phone       : " << _Phone << endl;
        cout << "Salary      : " <<_Salary << endl;
        cout << "Department  : " << _Department << endl;
        cout << "_________________________________\n";
    }


};


int main()
{
    clsEmployee Employee1(10, "karim", "guendouz","Welcom", "karim@gmail.com", "0668650682",3456.78,"Math");
    Employee1.Print();
    Employee1.SendEmail("Hi", "How are you ?");
    Employee1.SendSMS("How are you ?");
    return 0;
}
