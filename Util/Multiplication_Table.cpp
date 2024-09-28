#include <iostream>
using namespace std;
void PrintHead()
{
    cout<<"\t\t\t Multipaction Table From 1 to 10\n";
    for(int i=1;i<=10;i++)
    {
        cout<<"\t"<<i;
    }
    cout<<"\n-----------------------------------------------------------------------------------\n";
}
string ColumSeperatore(int i)
{
    if(i<10)
    {
        return "   |";
    }
    return "  |";
}
void TableMul()
{
    PrintHead();
    for(int i=1;i<=10;i++)
    {
        cout<<" "<<i<<ColumSeperatore(i)<<"\t";
        for(int j=1;j<=10;j++)
        {
             cout<<i*j<<"\t";
        }
        cout<<"\n";
    }
}
int main()
{
    TableMul();
    return 0;
}
