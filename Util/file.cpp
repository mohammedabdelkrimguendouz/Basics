#include <iostream>
#include<fstream>
#include<vector>
using namespace std;

void OpenWriteMode(string FileName)
{
    fstream MyFile;
    MyFile.open(FileName,ios::out);
    if(MyFile.is_open())
    {
        MyFile<<"karim c++\n";
        MyFile<<"ali pascal\n";
        MyFile<<"amin \n";
        MyFile.close();
    }
}

void OpenWriteModeOrAppendMode(string FileName)
{
     fstream MyFile;
     MyFile.open(FileName,ios::out | ios::app);
     if(MyFile.is_open())
    {
        MyFile<<"samir \n";
        MyFile<<"yacine \n";
        MyFile<<"mohammed\n";
        MyFile.close();
    }
}
void PrintFileWithReadMode(string FileName)
{
    cout<<" --------- print file ------------\n\n";
    fstream MyFile;
    MyFile.open(FileName,ios::in);
    if(MyFile.is_open())
    {
        string Line;
        while(getline(MyFile,Line))
        {
            cout<<Line<<endl;
        }
        MyFile.close();
    }
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

void LoadDataFromFileToVectore(string FileName,vector<string> &vFileContent)
{
    fstream MyFile;
    MyFile.open(FileName,ios::in);
    if(MyFile.is_open())
    {
         string Line;
         while(getline(MyFile,Line))
        {
            vFileContent.push_back(Line);
        }
        MyFile.close();
    }
}

void PrintVector(vector<string> &vFileContent)
{
    cout<<" --------- print vector ------------\n\n";
    for(string Text:vFileContent)
    {
        cout<<Text<<endl;
    }
}

void LoadDataFromVectoreToFile(string FileName,vector<string> &vFileContent)
{
    fstream MyFile;
    MyFile.open(FileName,ios::out);
    if(MyFile.is_open())
    {
        for(string Line:vFileContent)
        {
           if(Line!="")
           {
            MyFile<<Line<<endl;
           }
       }
       MyFile.close();
    }

}

void DeleteRecordFromFile(string FileName,string Record)
{
    vector<string>vFileContent;
    LoadDataFromFileToVectore(FileName,vFileContent);
    for(string &Line:vFileContent)
    {
        if(Line==Record)
        {
            Line="";
        }
    }
    LoadDataFromVectoreToFile(FileName,vFileContent);
}

void UpdateRecordFromFile(string FileName,string Record,string Update)

{
    vector<string>vFileContent;
    LoadDataFromFileToVectore(FileName,vFileContent);
    for(string &Line:vFileContent)
    {
        if(Line==Record)
        {
            Line=Update;
        }
    }
    LoadDataFromVectoreToFile(FileName,vFileContent);
}

int main()
{
    cout<<"\nFile content before delete \n";
    PrintFileWithReadMode("MyFile.txt");
    //DeleteRecordFromFile("MyFile.txt","ali");
    UpdateRecordFromFile("MyFile.txt","ali","amine");
    cout<<"\nFile content afhter delete \n";
    PrintFileWithReadMode("MyFile.txt");
    return 0;
}
