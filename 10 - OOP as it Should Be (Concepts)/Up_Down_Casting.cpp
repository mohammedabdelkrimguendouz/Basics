#include <iostream>
using namespace std;
class clsPerson
{
public:
    string FullName = "Karim Guendouz";
};
class clsEmployee:public clsPerson
{
public:
    string Title = "CEO";
};
int main()
{
    clsEmployee Employee1;
    cout<<Employee1.FullName << endl;
    // UpCasting 
    clsPerson* Person1 = &Employee1; // تحويل من كبير الى صغير //كبير تستطيع تصغيره 
    cout << Person1->FullName<<endl;
    // DownCasting
    clsPerson Person2;
    cout << Person2.FullName << endl;
    clsEmployee* Employee2 = &Person2; // تحويل من صغير الى كبير لاتستطيع

    return 0;
}