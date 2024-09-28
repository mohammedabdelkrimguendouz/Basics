#include <iostream>
#include "clsPerson.h";
#include "clsEmployee.h";
#include "clsDeveploper.h";
using namespace std;

int main()
{
    clsEmployee Employee1(10, "KARIM", "GUENDOUZ", "@gmail.com", "0668650682", "CEO", "PROGRAMMING", 234.56);
    Employee1.Print();
    return 0;
}
