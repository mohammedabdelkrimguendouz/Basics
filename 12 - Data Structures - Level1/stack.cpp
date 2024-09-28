#include<iostream>
#include<stack>
using namespace std;
int main()
{
    stack<int>MyStack;
    MyStack.push(12);
    MyStack.push(10);
    MyStack.push(20);
    MyStack.push(0);
    MyStack.push(3);
    MyStack.push(17);

    cout<<"size: "<<MyStack.size()<<endl;
    cout<<"top: "<<MyStack.top()<<endl;
    cout<<"\n my stack is : ";
    while(!MyStack.empty())
    {
        cout<<MyStack.top()<<"  ";
        MyStack.pop();
    }
    //MyStack1.swap(MyStack2) تبديل بين اثنين
    return 0;
}
