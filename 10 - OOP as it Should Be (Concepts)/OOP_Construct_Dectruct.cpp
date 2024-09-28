#include<iostream>
using namespace std;

class clsAdress
{
private:
    string _AdressLine1 = "";
    string _AdressLine2 = "";
    string _POBox = "";
    string _ZipCode = "";
public:
    clsAdress(string AdressLine1, string AdressLine2, string POBox, string ZipCode)
    {
        _AdressLine1 = AdressLine1;
        _AdressLine2 = AdressLine2;
        _POBox = POBox;
        _ZipCode = ZipCode;
        cout << "Im Construct\n";
    }
    /*clsAdress(clsAdress& Adress) // copy construct pour copy object from object compile defule write this code 
    {
        _AdressLine1 = Adress.AdressLine1();
        _AdressLine2 = Adress.AdressLine2();
        _POBox = Adress.POBox();
        _ZipCode = Adress.ZipCode();
    }
    */
    ~clsAdress()
    {
       // اخر دالة تتنفذ
       // يتم الدخول اليها وتحطيم اوبجكت
       // عند استخدام  allocation dynamike object == لاينم تحطيمه الا بعد حذف اوبجكت ب delete
       // 
        cout << "Im Destruct\n";
    }
    void SetAdressLine1(string AdressLine1)
    {
        _AdressLine1 = AdressLine1;
    }
    void SetAdressLine2(string AdressLine2)
    {
        _AdressLine2 = AdressLine2;
    }
    void SetPOBox(string POBox)
    {
        _POBox = POBox;
    }
    void SetZipCode(string ZipCode)
    {
        _ZipCode = ZipCode;
    }
    string AdressLine1()
    {
        return _AdressLine1;
    }
    string AdressLine2()
    {
        return _AdressLine2;
    }
    string POBox()
    {
        return _POBox;
    }
    string ZipCode()
    {
        return _ZipCode;
    }
    void Print()
    {
        cout << "Adress Details:\n";
        cout << "---------------------------\n";
        cout << "AdressLine1 : " << _AdressLine1 << endl;
        cout << "AdressLine2 : " << _AdressLine2 << endl;
        cout << "POBox       : " << _POBox << endl;
        cout << "ZipCode     : " << _ZipCode << endl;
    }
};

void Fun1()
{
    clsAdress Adress1("karim", "karim", "1", "1");
    Adress1.Print();
}
void Fun2()
{
    clsAdress* Adress2 = new clsAdress("ali", "ali", "1", "1");
    delete Adress2;
}

int main()
{
    Fun1();
    Fun2();
    system("pause>0");
    return 0;
}
