#include <iostream>
using namespace std;
class clsA
{
private:
    int V1;
    int Fun1()
    {
        return 1;
    }
protected:
    int V2;
    int Fun2()
    {
        return 2;
    }
public:
    int V3;
    int Fun3()
    {
        return 3;
    }
};
class clsB :public clsA
{
public:
    int Fun4()
    {
        Fun2(); // protected
        Fun3(); // public
        V2; // protected
        V3; // public
        return 4;
    }
};
class clsC :private clsA
{
public:
    int Fun5()
    {
        Fun2(); // private
        Fun3(); // private
        V2; // private
        V3; // private
        return 5;
    }
};
class clsD :protected clsA
{
public:
    int Fun6()
    {
        Fun2(); // protected
        Fun3(); // protected
        V2; // protected
        V3; // protected
        return 6;
    }
};
int main()
{
    //clsA A1;
    //clsB B1;
   // clsC C1;
    //clsD D1;
    return 0;
}
