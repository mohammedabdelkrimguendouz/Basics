
#include <iostream>
#include<map>
using namespace std;
int main()
{
    map<string, int> studentGrades;
       //Key    //value
    studentGrades["karim"] = 77;
    studentGrades["ali"] = 12;
    studentGrades["samir"] = 34;
    studentGrades["rakwan"] = 88;
    studentGrades["ahmed"] = 60;
    cout << "\n "<<studentGrades["ali"]<<"\n";
    for (const auto& Pair : studentGrades) // عرض جميع القيم //جميع القيم تكون مرتبة حسب Key
    {
        cout << "Studiant : " << Pair.first << "|    Grade : " << Pair.second << endl;
    }
    string name = "Karim";
    if (studentGrades.find(name) != studentGrades.end())
    {
        cout <<"\n Grade " << studentGrades[name]<<endl;
    }
    return 0;
}
