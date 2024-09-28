#pragma once
#include<iostream>
#include"clsScreen.h"
#include"clsBankClient.h"
#include<vector>
using namespace std;
class clsTransferLogScreen:protected clsScreen
{
private:
    static void  _PrintTranferLogRegisterRecordLine(clsBankClient::stTransferLogRecord TransferLogRecord)
    {
        cout << setw(8) << left << "" << "| " << setw(23) << left << TransferLogRecord.DateTime;
        cout << "| " << left << setw(8) << TransferLogRecord.SourceAccountNumber;
        cout << "| " << left << setw(8) << TransferLogRecord.DestinationAccountNumber;
        cout << "| " << left << setw(8) << TransferLogRecord.Amount;
        cout << "| " << left << setw(10) << TransferLogRecord.srcBalanceAfter;
        cout << "| " << left << setw(10) << TransferLogRecord.destBalanceAfter;
        cout << "| " << left << setw(8) << TransferLogRecord.UserName;
    }
public:
	static void ShowTransferLogScreen()
	{
        vector<clsBankClient::stTransferLogRecord> vTransferLogRecord = clsBankClient::GetTransferLogList();
        string Title = "\tTransfer Log List Screen";
        string SubTitle = "\t      (" + to_string(vTransferLogRecord.size()) + ") Record(s).";
        _DrawScreenHeader(Title, SubTitle);
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        cout << setw(8) << left << "" << "| " << setw(23) << left << "Date/Time";
        cout << "| " << left << setw(8) << "s.Acct";
        cout << "| " << left << setw(8) << "d.Acct";
        cout << "| " << left << setw(8) << "Amount";
        cout << "| " << left << setw(10) << "s.Balance";
        cout << "| " << left << setw(10) << "d.Balance";
        cout << "| " << left << setw(8) << "User";
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        if (vTransferLogRecord.size() == 0)
        {
            cout << "\t\t\t\t\tNo Users Available In The System!";
        }
        else
        {
            for (clsBankClient::stTransferLogRecord Record : vTransferLogRecord)
            {
                _PrintTranferLogRegisterRecordLine(Record);
                cout << endl;
            }
        }
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________" << endl;
    }
	
};

