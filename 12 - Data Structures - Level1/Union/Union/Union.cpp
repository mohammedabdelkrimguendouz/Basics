
#include <iostream>
using namespace std;
union MyUnion
{ //  Union : المتغيرات يحجز لها مكان واحد في الرام وهو حجم اكبر عنصر فبهم حفاظا على مساحة الرام
  // struct : كل متغير يححز له في الرام مساحة عكس يونيون
    int intValue;
    float floatValue;
    char charValue;
};
int main()
{
    MyUnion myUnion;
    myUnion.intValue = 42;
    cout << "int value :" << myUnion.intValue << endl;
    myUnion.floatValue = 3.14;
    cout << "float value :" << myUnion.floatValue << endl;
    myUnion.charValue = 'A';
    cout << "int  value :" << myUnion.intValue << endl; // خطا لان اخر قيمة وضعنها هي حرف
    cout << "char value :" << myUnion.charValue << endl;
    return 0;
}

