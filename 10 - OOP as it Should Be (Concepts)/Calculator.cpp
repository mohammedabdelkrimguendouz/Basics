#include<iostream>
using namespace std;
class clsCalculatore
{
private:
    float _LastNumber=0;
    float _Result=0;
    string _LastOperation="Clear";
    float _PreviousResult=0;
    bool _IsZero(float Number)
    {
        return (Number==0);
    }
public:
    void Add(float Number)
    {
        _LastOperation="Adding";
        _PreviousResult=_Result;
        _LastNumber=Number;
        _Result+=Number;
    }
    void SubTract(float Number)
    {
        _LastOperation="Suptracting";
        _PreviousResult=_Result;
        _LastNumber=Number;
        _Result-=Number;
    }
    void Multiply(float Number)
    {
       _LastOperation="Multiplying";
       _PreviousResult=_Result;
        _LastNumber=Number;
        _Result*=Number;
    }
    void Divide(float Number)
    {
        _LastNumber=Number;
        if(_IsZero(Number))
        {
            Number=1;
        }
        _LastOperation="Dividing";
        _PreviousResult=_Result;
        _Result/=Number;
    }
    float GetFinalResult()
    {
        return _Result;
    }
    void Clear()
    {
        _LastOperation="Clear";
        _PreviousResult=0;
        _LastNumber=0;
        _Result=0;
    }
    void CencleLastOperation()
    {
       _LastNumber=0;
       _LastOperation="Cencelling Last Operation";
       _Result=_PreviousResult;
    }
    void PrintResult()
    {
         cout<<"Result Afther "<<_LastOperation<<"  "<<_LastNumber<<" is : "<<_Result<<endl;
    }

};
int main()
{
    clsCalculatore Calculatore1;
    Calculatore1.Add(10);
    Calculatore1.PrintResult();
    Calculatore1.Add(100);
    Calculatore1.PrintResult();
    Calculatore1.SubTract(20);
    Calculatore1.PrintResult();
    Calculatore1.Divide(0);
    Calculatore1.PrintResult();
    Calculatore1.Divide(2);
    Calculatore1.PrintResult();
    Calculatore1.Multiply(3);
    Calculatore1.PrintResult();
    Calculatore1.CencleLastOperation();
    Calculatore1.PrintResult();
    Calculatore1.Clear();
    Calculatore1.PrintResult();
    return 0;
}

