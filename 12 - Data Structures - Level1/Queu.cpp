#include<iostream>
#include<queue>
using namespace std;
int main()
{
    queue<int>MyQueue;
    MyQueue.push(5);
    MyQueue.push(10);
    MyQueue.push(20);
    MyQueue.push(0);
    MyQueue.push(3);
    MyQueue.push(17);

    cout<<"size: "<<MyQueue.size()<<endl;
    cout<<"front: "<<MyQueue.front()<<endl;
    cout<<"back: "<<MyQueue.back()<<endl;
    cout<<"\n my queue is : ";
    while(!MyQueue.empty())
    {
        cout<<MyQueue.front()<<"  ";
        MyQueue.pop();
    }

    //MyQueue1.swap(MyQueue2) تبديل بين اثنين
    return 0;
}
