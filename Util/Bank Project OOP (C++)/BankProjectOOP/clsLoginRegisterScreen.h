#pragma once
#include<iostream>
#include"clsScreen.h"
#include"clsUser.h"
using namespace std;
class clsLoginRegisterScreen:protected clsScreen
{
private:
    static void _PrintLoginRegisterRecordLine(clsUser::stLoginRegisterRecord Record)
    {
        cout << setw(8) << left << "" << "| " << setw(35) << left << Record.DateTime;
        cout << "| " << left << setw(20) << Record.UserName;
        cout << "| " << left << setw(20) << Record.Password;
        cout << "| " << left << setw(15) << Record.Permissions;
    }
public:
	static void ShowLoginRegisterScreen()
	{
        if (!CheckAccessRights(clsUser::enParmissions::pShowLogInRegister))
        {
            return;
        }
		vector<clsUser::stLoginRegisterRecord> vLogInRegisterRecord = clsUser::GetLoginRegisterList();
		string Title = "\tLogin Register List Screen";
		string SubTitle = "\t      (" + to_string(vLogInRegisterRecord.size()) + ") Record(s).";
		_DrawScreenHeader(Title, SubTitle);
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        cout << setw(8) << left << "" << "| " << setw(35) << left << "Date/Time";
        cout << "| " << left << setw(20) << "User Name";
        cout << "| " << left << setw(20) << "Password";
        cout << "| " << left << setw(10) << "Permissions";
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        if (vLogInRegisterRecord.size() == 0)
        {
            cout << "\t\t\t\tNo Users Available In The System!";
        }
        else
        {
            for (clsUser::stLoginRegisterRecord Record : vLogInRegisterRecord)
            {
                _PrintLoginRegisterRecordLine(Record);
                cout << endl;
            }
        }
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________" << endl;
    }
};

