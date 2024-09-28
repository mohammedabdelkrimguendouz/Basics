#pragma once
#include <iostream>
#include"clsString.h"
#include"clsPerson.h"
#include<string>
#include<fstream>
#include"clsDate.h"
#include<vector>
using namespace std;
class clsBankClient :public  clsPerson
{
private:
	enum enMode { EmptyMode = 0, UpdateMode = 1,AddNewMode=2 };
	enMode _Mode;
	string _AccountNumber;
	string _PinCode;
	float _AccountBalance;
	bool _MarkedForDelete = false;
	static clsBankClient _ConvertLineToClientObject(string Line,string Seperator="#//#")
	{
		vector<string> vClientData = clsString::Split(Line, Seperator);
		return clsBankClient(enMode::UpdateMode,vClientData[0], vClientData[1], vClientData[2],
			vClientData[3], vClientData[4], vClientData[5], stod(vClientData[6]));
	}
	static string _ConvertClientObjectToLine(clsBankClient Client, string Seperator = "#//#")
	{
		string stClientRecord = "";
		stClientRecord += Client.FirstName+Seperator;
		stClientRecord += Client.LastName + Seperator;
		stClientRecord += Client.Email + Seperator;
		stClientRecord += Client.Phone + Seperator;
		stClientRecord += Client.AccountNumber() + Seperator;
		stClientRecord += Client.PinCode + Seperator;
		stClientRecord += to_string(Client.AccountBalance);
		return stClientRecord;
	}
	static clsBankClient _GetEmptyClientObject()
	{
		return clsBankClient(enMode::EmptyMode, "", "", "", "", "", "", 0);
	}
	static vector<clsBankClient> _LoadClientDataFromFile()
	{
		vector<clsBankClient> vClientData;
		fstream MyFile;
		MyFile.open("Clients.txt", ios::in);
		if (MyFile.is_open())
		{
			string Line;
			while (getline(MyFile,Line))
			{
				clsBankClient Client = _ConvertLineToClientObject(Line);
				vClientData.push_back(Client);
			}
			MyFile.close();
		}
		return vClientData;
	}
	void _SaveTransaction()
	{
		vector<clsBankClient> vClients = GetClientsList();
		for (clsBankClient& C : vClients)
		{
			if (C.AccountNumber() == _AccountNumber)
			{
				C.AccountBalance = _AccountBalance;
				break;
			}
		}
		_SaveClientsDataToFile(vClients);

	}
	static void _SaveClientsDataToFile(vector<clsBankClient> vClients)
	{
		fstream MyFile;
		MyFile.open("Clients.txt", ios::out);
		if (MyFile.is_open())
		{
			string DataLine = "";
			for (clsBankClient C : vClients)
			{
				if (C.MerkedForDelete() == false)
				{
					DataLine = _ConvertClientObjectToLine(C);
					MyFile << DataLine << endl;
				}
			}
			MyFile.close();
		}
	}
	void _AddDataLineToFile(string stDataLine)
	{
		fstream MyFile;
		MyFile.open("Clients.txt", ios::out | ios::app);
		if (MyFile.is_open())
		{
			MyFile << stDataLine << endl;
			MyFile.close();
		}
	}
	string _PrepareTransferLogRecord(float Amount, clsBankClient DestinationClient, string UserName,string  Seperator = "#//#")
	{
		string sTransferLogRecord = "";
		sTransferLogRecord += clsDate::GetSystemDateTimeString() + Seperator;;
		sTransferLogRecord += AccountNumber() + Seperator;
		sTransferLogRecord += DestinationClient.AccountNumber() + Seperator;
		sTransferLogRecord += to_string(Amount) + Seperator;
		sTransferLogRecord += to_string(AccountBalance) + Seperator;
		sTransferLogRecord += to_string(DestinationClient.AccountBalance) + Seperator;
		sTransferLogRecord +=UserName;
		return sTransferLogRecord;
	}
	void _RegisterTransferLog(float Amount,clsBankClient DestinationClient,string UserName)
	{
		
		string stDataLine = _PrepareTransferLogRecord(Amount,DestinationClient, UserName);
		fstream MyFile;
		MyFile.open("TransferLog.txt", ios::out | ios::app);
		if (MyFile.is_open())
		{
			MyFile << stDataLine << endl;
			MyFile.close();
		}
	}
	void _Update()
	{
		vector<clsBankClient>_vClients = _LoadClientDataFromFile();
		for (clsBankClient& C : _vClients)
		{
			if (C.AccountNumber() == AccountNumber())
			{
				C = *this;
				break;
			}
		}
		_SaveClientsDataToFile(_vClients);
	}
	void _AddNew()
	{
		_AddDataLineToFile(_ConvertClientObjectToLine(*this));
	}
	struct stTransferLogRecord;
	static stTransferLogRecord _ConvertTransferLogLineToRecord(string Line,string Seperator = "#//#")
	{
		vector<string> vTransferLogDataLine=clsString::Split(Line,Seperator);
		stTransferLogRecord RecordTransferLog;
		
		RecordTransferLog.DateTime = vTransferLogDataLine[0];
		RecordTransferLog.SourceAccountNumber = vTransferLogDataLine[1];
		RecordTransferLog.DestinationAccountNumber = vTransferLogDataLine[2];
		RecordTransferLog.Amount = stod(vTransferLogDataLine[3]);
		RecordTransferLog.srcBalanceAfter = stod(vTransferLogDataLine[4]);
		RecordTransferLog.destBalanceAfter = stod(vTransferLogDataLine[5]);
		RecordTransferLog.UserName = vTransferLogDataLine[6];
		
		return RecordTransferLog;
	}

public:
	clsBankClient(enMode Mode,string FirstName, string LastName, string Email, string Phone,
		string AccountNumber, string PinCode, float AccountBalance) :
		clsPerson(FirstName, LastName, Email, Phone)
	{
		_Mode = Mode;
		_AccountNumber = AccountNumber;
		_PinCode = PinCode;
		_AccountBalance = AccountBalance;
	}

	struct stTransferLogRecord
	{
		string DateTime;
		string SourceAccountNumber;
		string DestinationAccountNumber;
		float Amount;
		float srcBalanceAfter;
		float destBalanceAfter;
		string UserName;
	};
	bool IsEmpty()
	{
		return (_Mode == enMode::EmptyMode);
	}
	void SetAccountBalance(float AccountBalance)
	{
		_AccountBalance = AccountBalance;
	}
	float GetAccountBalance()
	{
		return _AccountBalance;
	}
	__declspec(property(get = GetAccountBalance, put = SetAccountBalance))float AccountBalance;
	void SetPinCode(string PinCode)
	{
		_PinCode = PinCode;
	}
	string GetPinCode()
	{
		return _PinCode;
	}
	__declspec(property(get = GetPinCode, put = SetPinCode))string PinCode;
	string AccountNumber()
	{
		return _AccountNumber;
	}
	bool MerkedForDelete()
	{
		return _MarkedForDelete;
	}
	static clsBankClient Find(string AccountNumber)
	{
		vector<clsBankClient> vClietnts;
		fstream MyFile;
		MyFile.open("Clients.txt", ios::in);
		if (MyFile.is_open())
		{
			string Line;
			while (getline(MyFile,Line))
			{
				clsBankClient Client = _ConvertLineToClientObject(Line);
				if (Client.AccountNumber()==AccountNumber) {
					MyFile.close();
					return Client;
				}
				vClietnts.push_back(Client);
			}
			MyFile.close();
		}
		return _GetEmptyClientObject();
	}
	static clsBankClient Find(string AccountNumber,string PinCode)
	{
		vector<clsBankClient> vClietnts;
		fstream MyFile;
		MyFile.open("Clients.txt", ios::in);
		if (MyFile.is_open())
		{
			string Line;
			while (getline(MyFile, Line))
			{
				clsBankClient Client = _ConvertLineToClientObject(Line);
				if (Client.AccountNumber()==AccountNumber  && Client.PinCode==PinCode) {
					MyFile.close();
					return Client;
				}
				vClietnts.push_back(Client);
			}
			MyFile.close();
		}
		return _GetEmptyClientObject();
	}
	static bool IsClientExist(string AccountNumber)
	{
		clsBankClient Client = clsBankClient::Find(AccountNumber);
		return (!Client.IsEmpty());
	}
	static clsBankClient GetAddNewClientObject(string AccountNumber)
	{
		return clsBankClient(enMode::AddNewMode, "", "", "", "", AccountNumber, "", 0);
	}
	enum enSaveResults{svFaildEmptyObject=0,svSucceeded=1,svFaildAccountNumberExist=2};
	enSaveResults Save()
	{
		switch (_Mode)
		{
		case enMode::EmptyMode:
		{
			if (IsEmpty())
			{
                return enSaveResults::svFaildEmptyObject;
			}
		}
			
		case enMode::UpdateMode:
		{
            _Update();
			return enSaveResults::svSucceeded;
			break;
		}
		case enMode::AddNewMode:
		{
			if (clsBankClient::IsClientExist(_AccountNumber))
			{
				return enSaveResults::svFaildAccountNumberExist;
			}
			else
			{
				_AddNew();
				_Mode = enMode::UpdateMode;
				return enSaveResults::svSucceeded;
			}
			break;
		}
		}
	}
	bool Delete()
	{
		vector<clsBankClient> vClients = _LoadClientDataFromFile();
		for (clsBankClient& C : vClients)
		{
			if (C.AccountNumber() == _AccountNumber)
			{
				C._MarkedForDelete = true;
				break;
			}
		}
		_SaveClientsDataToFile(vClients);
		*this = _GetEmptyClientObject();
		return true;
	}
	static vector<clsBankClient> GetClientsList()
	{
		return _LoadClientDataFromFile();
	}
	static double GetTotalBalances()
	{
		vector<clsBankClient> vClients = GetClientsList();
		double TotalBalances =0;
		for (clsBankClient C : vClients)
		{
			TotalBalances += C.AccountBalance;
		}
		return TotalBalances;
	}
	void Deposit(double Amount)
	{
		_AccountBalance += Amount;
		_SaveTransaction();
	}
	bool Withdraw(double Amount)
	{
		if (Amount<0 || Amount>_AccountBalance)
		{
			return false;
		}
		else
		{
			_AccountBalance -= Amount;
			_SaveTransaction();
			return true;
		}
	}
	bool Transfer(float Amount, clsBankClient& DestinationClient,string UserName)
	{
		if (Amount > AccountBalance)
		{
			return false;
		}
		else
		{
			Withdraw(Amount);
			DestinationClient.Deposit(Amount);
			_RegisterTransferLog(Amount , DestinationClient,UserName);
			
			return true;
		}
	}
	static vector<stTransferLogRecord> GetTransferLogList()
	{
		vector<stTransferLogRecord> vTransferLogRecord;
		fstream MyFile;
		MyFile.open("TransferLog.txt", ios::in);
		if (MyFile.is_open())
		{
			string Line;
			stTransferLogRecord TranferRecord;
			while (getline(MyFile, Line))
			{
				TranferRecord = _ConvertTransferLogLineToRecord(Line);
				vTransferLogRecord.push_back(TranferRecord);
			}
			MyFile.close();
		}
		return vTransferLogRecord;
	}
};

	