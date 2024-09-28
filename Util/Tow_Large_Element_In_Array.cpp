#include <iostream>

using namespace std;
int great_number_2(int arr[],int n)
{
    int first,second;
    first=second=INT_MIN;
    for(int i=0;i<n;i++)
    {
        if(arr[i]>first)
        {
            second=first;
            first=arr[i];
        }
        else if(arr[i]>second && arr[i]!=first)second=arr[i];
    }

    if(second!=INT_MIN)
    {
        cout<<"second :"<<second<<endl;
        return second;
    }
    else
    {
        cout<<"second n'exist pas\n";
        return INT_MIN;
    }

}
int main()
{
    int arr[]={10,20,20,20,20,20};
    int n=sizeof(arr)/sizeof(arr[0]);
    int sec=great_number_2(arr,n);
    return 0;
}
