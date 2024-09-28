#include <iostream>
#include<time.h>
#include<cstdlib>
using namespace std;
int ReadNumberKey()
{
    int NumberKey;
    cout<<"Write Number Key? ";
    cin>>NumberKey;
    return NumberKey;
}
int RandomNumber(int From,int To)
{
                //  %(to-from+1)+from // 1..  10;
        return rand()%(To-From+1)+From;
}
void PrintKey(int NumberKey)
{


        for(int i=0;i<NumberKey;i++)
        {
          cout<<" "<<"Key["<<i+1<<"]: ";
           for(int k=0;k<4;k++)
           {
               for(int j=0;j<4;j++)
               {
               cout<<char(RandomNumber(65,90));
               }
               cout<<"-";
           }
           cout<<endl;
        }
}


int main()
{
    srand((unsigned)time(NULL));
    PrintKey(ReadNumberKey());
    return 0;
}
