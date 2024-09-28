#include <iostream>

using namespace std;

int main()
{
    int Size=0;
    cout<<"write nomber of tablea ";
    cin>>Size;
    float* ptr=new float[Size];
    for(int i=0;i<Size;i++)
    {
        cout<<"student "<<i+1<<" : ";
        cin>>ptr[i];
        //cin>>*(ptr+i);
    }
    for(int i=0;i<Size;i++)
    {
        cout<<"student "<<i+1<<" : "<<ptr[i]<<endl;
                                      //*(ptr+i);
    }
    delete[] ptr;
    return 0;
}
