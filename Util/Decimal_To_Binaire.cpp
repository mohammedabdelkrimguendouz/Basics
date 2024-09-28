#include <iostream>
using namespace std;
int ConvertDecimailToBinaire(int n)
{
    int binaire_number=0,base=1;
    while(n>0)
    {
        int rem=n%2;
        binaire_number=binaire_number+rem*base;
        base=base*10;
        n=n/2;
    }
    return binaire_number;
}
int main()
{
    int n,bin;
    cout << "Write number decimal pour convert to binaire : " ;
    cin>>n;
    bin=ConvertDecimailToBinaire(n);
    cout<<" code binaire pour number  < "<<n<<" > : "<<bin<<endl;
    return 0;
}
