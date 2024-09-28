#include<iostream>
using namespace std;

void SeriFibonatchiIterative(int Number)
{
    int prev2=1;
    int prev1=0;
    int fib=0;
    for(int i=0;i<Number;i++ )
    {
         fib=prev1+prev2;
         prev2=prev1;
         prev1=fib;
         cout<< fib <<"  ";
    }
    cout<<endl;
}

void SeriFibonatchiRecursion(int Number,int prev1,int prev2)
{
    int fib=0;
    if(Number>0)
    {
         fib=prev1+prev2;
         prev2=prev1;
         prev1=fib;
         cout<< fib <<"  ";
         SeriFibonatchiRecursion(Number-1,prev1,prev2);
    }
}

int main()
{
    SeriFibonatchiIterative(10);
    SeriFibonatchiRecursion(10,0,1);
    return 0;
}
