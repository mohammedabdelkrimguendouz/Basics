#include<iostream>

using namespace std;
void PrintRecursion(int N,int M)
{
    if(M>=N)
    {
        cout<<M<<endl;
        PrintRecursion(N,M-1);
    }
}

int Power(int N,int M)
{
    if(M==0)
    {
        return 1;
    }
    else
    {
        return N*Power(N,M-1);
    }
}

int main()
{
    PrintRecursion(1,10);
    cout<<Power(2,3);
    return 0;
}
