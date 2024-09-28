#include <iostream>
using namespace std;
string Encryption(string EncryptionString,short Key)
{
    for(int i=0;i<EncryptionString.length();i++)
    {
        EncryptionString[i]=char((int)EncryptionString[i]+(Key*Key-10));
    }
    return EncryptionString;
}

string Decryption(string DecryptionString,short Key)
{
    for(int i=0;i<DecryptionString.length();i++)
    {
        DecryptionString[i]=char((int)DecryptionString[i]-(Key*Key-10));
    }
    return DecryptionString;
}


string ReadText()
{
    string Text;
    cout<<"Enter a text for encryption && decryption  : ";
    do
    {
        getline(cin,Text);
    }while(Text=="");
    cout<<"\n";
    return Text;
}
int main()
{
    const short EncrptionKey=2;
    cout<<"\t\t\t\t < Encryption && Decryption > \n\n";
    string Text=ReadText();
    cout<<" Text Before Encryption : "<<Text<<endl<<endl;
    cout<<" Text After  Encryption : "<<Encryption(Text,EncrptionKey)<<endl<<endl;
    cout<<" Text After  Decryption : "<<Decryption(Encryption(Text,EncrptionKey),EncrptionKey)<<endl<<endl;
    system("pause");
    return 0;
}
