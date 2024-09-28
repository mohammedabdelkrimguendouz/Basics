#include <iostream>
using namespace std;

class clsMobile // Class Abstruct / Interface / Contract / عبارة عن كلاس عقد لابمكن انشاء كائن منه والكلاس الذي بورثه يجب عليه تمثيل جميع الدوال في العقد
{
    virtual void Dial(string PhoneNumber) = 0;
    virtual void SendSMS(string PhoneNumber,string Text) = 0;
    virtual void TakePicture() = 0;
};

class clsIphone :public clsMobile
{
    virtual void Dial(string PhoneNumber)
    {

    }
    virtual void SendSMS(string PhoneNumber, string Text)
    {

    }
    virtual void TakePicture()
    {

    }
    void MyOneMethode()
    {

    }
};

int main()
{
    clsIphone iphone1;
    return 0;
}
