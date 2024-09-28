#include<iostream>
#include<string>
#include<vector>
#include<fstream>
using namespace std;
const string FileName="string.txt";

struct stClient
{
    string Name;
    int Key;
    double Slary;
    bool isFull;
};

stClient ReadRecord()
{
    stClient Client;

    cout<<" enter name ? ";
    getline(cin>>ws,Client.Name);
    cout<<" enter key ? ";
    cin>> Client.Key;
    cout<<" enter salary ? ";
    cin>> Client.Slary;
    Client.isFull=true;

    return Client;
}
string ReadText()
{
    string Text="";
    cout<<"\n enter text ? "<<endl;
    getline(cin,Text);
    return Text;
}

void PrintAllFirstLetterFromText(string Text)
{
    bool isFirstLetter=true;
    for(int i=0;i<Text.length();i++)
    {
        if(Text[i]!=' '&&isFirstLetter==true)
        {
            cout<<toupper(Text[i]);
        }
        isFirstLetter=(Text[i]==' '?true:false);
    }
}


string UpperAllFirstLetterFromText(string Text)
{
    bool isFirstLetter=true;
    for(int i=0;i<Text.length();i++)
    {
        if(Text[i]!=' '&&isFirstLetter==true)
        {
            Text[i]=toupper(Text[i]);
        }
        isFirstLetter=(Text[i]==' '?true:false);
    }
    return Text;
}


string LowerAllFirstLetterFromText(string Text)
{
    bool isFirstLetter=true;
    for(int i=0;i<Text.length();i++)
    {
        if(Text[i]!=' '&&isFirstLetter)
        {
            Text[i]=tolower(Text[i]);
        }
        isFirstLetter=(Text[i]==' '?true:false);
    }
    return Text;
}

string ConvertTextToLowerLetter(string Text)
{
    for(int i=0;i<Text.length();i++)
    {
        Text[i]=tolower(Text[i]);
    }
    return Text;
}


string ConvertTextToUpperLetter(string Text)
{
    for(int i=0;i<Text.length();i++)
    {
        Text[i]=toupper(Text[i]);
    }
    return Text;
}

char InvertChar(char  Letter)
{
    return isupper(Letter)?tolower(Letter):toupper(Letter);
}

void PrintWordFromText(string Text)
{
    string Word="";
    Text+=" ";
    for(int i=0;i<Text.length();i++)
    {
        if(Text[i]!=' ')
        {
            Word+=Text[i];
        }
        else
        {
            cout<<Word<<endl;
            Word="";
        }
    }
}

void PrintWordFromText2(string Text,string delim)
{
    string Word;
    short pos=0;
    while((pos=Text.find(delim)) != Text.npos)
    {
        Word=Text.substr(0,pos);
        if(Word!="")
        {
            cout<<Word<<endl;
        }
        Text.erase(0,pos+delim.length());
    }

    if(Text!="")
    {
        cout<<Text<<endl;
    }
}

string TrimLeft(string Text)
{
    for(int i=0;i<Text.length();i++)
    {
        if(Text[i]!=' ')
        {
            return Text.substr(i,Text.length()-i);
        }
    }
    return "";

}
string TrimRight(string Text)
{
    for(int i=Text.length()-1;i>=0;i--)
    {
        if(Text[i]!=' ')
        {
            return Text.substr(0,i+1);
        }
    }
    return "";
}

string TrimAll(string Text)
{
    return TrimRight(TrimLeft(Text));
}

string JoineString(vector<string> vString,string delim)
{
    string Word="";
    for(string &s : vString)
    {
       Word=Word+s+delim;
    }
    return Word.substr(0,Word.length()-delim.length());

}

vector<string> SplitString(string Text,string delim)
{
    vector<string> vString;
    string Word;
    short pos=0;
    while((pos=Text.find(delim)) != Text.npos)
    {
        Word=Text.substr(0,pos);
        if(Word!="")
        {
            vString.push_back(Word);
        }
        Text.erase(0,pos+delim.length());
    }

    if(Text!="")
    {
        vString.push_back(Text);
    }
    return vString;
}

string JoineString(string ArrString[],int SizeArr ,string delim)
{
    string Word="";
    for(int i=0;i<SizeArr;i++)
    {
        Word=Word+ArrString[i]+delim;
    }
    return Word.substr(0,Word.length()-delim.length());
}

string ReverseWordItsText(string Text)
{
    vector<string> vString=SplitString(Text," ");
    for(int i=0;i<vString.size()/2;i++)
    {
        string str=vString[i];
        vString[i]=vString[vString.size()-i-1];
        vString[vString.size()-i-1]=str;
    }
    return JoineString(vString," ");
}


string ReverseWordItsText2(string Text)
{
    string Word="";
    vector<string> vString=SplitString(Text," ");
    vector<string>::iterator iter=vString.end();
    while(iter!=vString.begin())
    {
        Word+=*iter+" ";
        iter--;
    }
    Word=Word.substr(0,Word.length()-1);
    return Word;
}

string ReplaceWordUsingBulteFunction(string S1,string FromReplace,string ToReplace)
{
    int pos=0;
    while((pos=S1.find(FromReplace)) != S1.npos)
    {
        S1=S1.replace(pos,FromReplace.length(),ToReplace);
    }
    return S1;
}

string ReplaceWordUsingSplite(string Text,string ToReplace,string ReplaceTo,bool MatchCase=true)
{
     vector<string> vString=SplitString(Text," ");
     for(string &s:vString)
     {
         if(MatchCase)
         {
             if(s==ToReplace)
             {
                 s=ReplaceTo;
             }
         }
         else
         {
             if(ConvertTextToLowerLetter(s)==ConvertTextToLowerLetter(ToReplace))
             {
                 s=ReplaceTo;
             }
         }
     }
     return JoineString(vString," ");
}

string RemovePunctuation(string Text)
{
    string Word="";
    for(char s:Text)
    {
        if(!ispunct(s))
        {
            Word+=s;
        }
    }
    return Word;
}

string ConvertRecordToLine(stClient Client,string Seperator="#//#")
{
    string Line="";
    Line+=Client.Name+Seperator;
    Line+=to_string(Client.Key)+Seperator;
    Line+=to_string(Client.Slary)+Seperator;
    Line+=to_string(Client.isFull);
    return Line;
}

stClient ConvertLineToRecord(string Text,string Seperator="#//#")
{
    vector<string>vRecord=SplitString(Text,Seperator);
    stClient Client;
    Client.Name=vRecord[0];
    Client.Key=stoi(vRecord[1]);
    Client.Slary=stod(vRecord[2]);
    Client.isFull=stoi(vRecord[3]);
    return Client;
}


void AddClientToFile(string FileName)
{
    fstream FileContent;
    char AddAgaine='Y';
    do
    {
        system("cls");
        cout<<"Adding New Client : \n\n";
        FileContent.open(FileName,ios::out | ios::app);
        stClient Client=ReadRecord();
        string Line=ConvertRecordToLine(Client);
        FileContent<<Line<<endl;
        FileContent.close();
        cout<<" \n Client Add Successfully ,do you want to add new client ? Y/N ? ";
        cin>>AddAgaine;
    }while(toupper(AddAgaine)=='Y');


}


int main()
{
    AddClientToFile(FileName);
    return 0;
}
