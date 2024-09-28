#include <iostream>
using namespace std;
void great_number_3(int arr[],int n)
{
    int first,second,third;
    first=second=third=INT_MIN;
    for(int i=0;i<n;i++)
    {
        if(arr[i]>first)
        {
            third=second;
            second=first;
            first=arr[i];
        }
        else if(arr[i]>second && arr[i]!=first)
        {
            third=second;
            second=arr[i];
        }
        else if(arr[i]>third&& arr[i]!=first && arr[i]!=second)
        {
            third=arr[i];
        }
    }

    cout<<"first : "<<first<<endl;
    if(second!=INT_MIN)
    {
        cout<<"second :"<<second<<endl;
        if(third==INT_MIN)cout<<"third n'exist pas\n";

        else cout<<"third : "<<third<<endl;
    }
    else
    {
        cout<<"second n'exist pas\n";
        cout<<"third n'exist pas\n";
    }

}
int main()
{
    int arr[]={20,20,20,20,20,20};
    int n=sizeof(arr)/sizeof(arr[0]);
    great_number_3(arr,n);
    return 0;
}
