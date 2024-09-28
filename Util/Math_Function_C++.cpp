#include <iostream>
#include<cmath>
using namespace std;
float Fraction(float Number)
{
    return Number-(int)Number;
}
float Sqrt(float Number)
{
    return pow(Number,0.5);
}
float ciel(float Number)
{
    if(abs(Fraction(Number))>0)
    {
        if(Number>0)
        {
        return int(Number)+1;
        }
        return int(Number);
    }
    else return Number;


}
float floor(float Number)
{
    int integer=int(Number);
    if(Number>=0)
    {
        return integer;
    }
    return --integer;

}
float round(float Number)
{
    int integer=int(Number);
    float FractionPart=Fraction(Number);
    if(abs(FractionPart)>=.5)
    {
        if(FractionPart>=0)
        {
            return ++integer;
        }
        else
        {
            return --integer;
        }
    }
    else
    {
        return integer;
    }
}
float ReadNumber()
{
    float x;
    cout<<"write number float : ";
    cin>>x;
    return x;
}
int main()
{

    cout<<Sqrt(ReadNumber());
    return 0;
}
