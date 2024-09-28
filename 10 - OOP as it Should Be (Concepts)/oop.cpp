#include<iostream>
using namespace std;
class clsPerson
{
private :
    string _FirstName;
    string _LastName;
public:
     void SetFirstName(string FirstName)
     {
         _FirstName=FirstName;
     }
     void SetLastName(string LastName)
     {
         _LastName=LastName;
     }
     string GetFirstName()
     {
         return _FirstName;
     }
     string GetLastName()
     {
         return _LastName;
     }
     string FullName()
     {
         return _FirstName+" "+_LastName;
     }
     __declspec(property(get = GetFirstName , put = SetFirstName)) string FirstName;

};

int main()
{
    clsPerson Person1;
    Person1.SetFirstName("karim");
    cout<<Person1.GetFirstName()<<endl;


    return 0;
}
