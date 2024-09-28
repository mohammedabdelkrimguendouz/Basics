
#include <iostream>
using namespace std;
template<typename T> T myMax(T Number1, T Number2)
{
    return (Number1 > Number2) ? Number1 : Number2;
}
int main()
{
    cout << myMax<int>(4, 8) << endl;
    cout << myMax<double>(4.647, 4.648) << endl;
    cout << myMax<char>('a', 'b') << endl;
    return 0;
}


