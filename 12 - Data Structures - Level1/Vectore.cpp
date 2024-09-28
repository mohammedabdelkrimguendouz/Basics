#include<iostream>
#include<vector>
using namespace std;
struct stEmployee
{
    string FirstName;
    string LastName;
    float Salary=0.0;
};
void PrintVectoreNumber(vector<int>&vNumber)
{
    for(int i:vNumber)
    {
        cout<<i<<endl;
    }
}
void ReadNumbers(vector<int>&vNumber)
{
    char ReadAgine='y';
    int Number;
    do
    {
        cout<<"Write Number ? ";
        cin>>Number;
        vNumber.push_back(Number);
        cout<<"Do you want add element in vectore Y / N: ";
        cin>>ReadAgine;
    }while(ReadAgine=='y'||ReadAgine=='Y');
}
void ReadEmployee(vector<stEmployee>&vEmployee)
{
    char ReadAgine='y';
    stEmployee Employee;
    do
    {
        cout<<"Write First Name ? ";
        cin>>Employee.FirstName;
        cout<<"Write Last Name ? ";
        cin>>Employee.LastName;
        cout<<"Write Salary  ? ";
        cin>>Employee.Salary;
        vEmployee.push_back(Employee);
        cout<<"Do you want add Employee in vectore Y / N: ";
        cin>>ReadAgine;
    }while(ReadAgine=='y'||ReadAgine=='Y');
}

void PrintVectoreEmployee(vector<stEmployee>&vEmployee)
{
    for(stEmployee i:vEmployee)
    {
        cout<<"\n--------------------\n";
        cout<<i.FirstName<<endl;
        cout<<i.LastName<<endl;
        cout<<i.Salary<<endl;
    }
}



int main()
{
    vector<int>vNumber;
    /*vector<stEmployee>vEmployee;
    ReadEmployee(vEmployee);
    PrintVectoreEmployee(vEmployee);
    vEmployee.pop_back();
    PrintVectoreEmployee(vEmployee);*/
    //ReadNumbers(vNumber);
    //PrintVectoreNumber(vNumber);
    //vEmployee.empty(); ترجع صحيح اذاكان فارغ
    //vEmployee.size(); يعطيك الحجم
    // vEmployee.clear();  حذف جميع العناصر
    //vEmployee.front();  يعطيك اول عنصر
    // vEmployee.back(); يعطيك اخر عنصر
    //vEmployee.at(/*insex*/) // الوصول الى عنصر
    //cout<<vEmployee[0]; // الوصول الى عنصر

    vector<int>num{1,2,3,4,5};
    vector<int>::iterator iter; // المرور عبر عناصر vectore باستخدام pointer
    for(iter=num.begin();iter!=num.end();iter++)
    {
        cout<<*iter<<endl;
    }
    return 0;
}
