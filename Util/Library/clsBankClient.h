#pragma once
#include <iostream>
#include"clsString.h"
#include"clsPerson.h"
#include<string>
#include<fstream>
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
	void Print()
	{
		cout << "\nClient Card : ";
		cout << "\n_____________________________";
		cout << "\nFirst Name     : " << FirstName;
		cout << "\nLast Name      : " << LastName;
		cout << "\nFull Name      : " << FullName();
		cout << "\nEmail          : " << Email;
		cout << "\nPhone          : " << Phone;
		cout << "\nAccount Number : " << _AccountNumber;
		cout << "\nPassword       : " << _PinCode;
		cout << "\nAccountBalance : " << _AccountBalance;
		cout << "\n_____________________________\n";
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
		vector<clsBankClient> _vClients = _LoadClientDataFromFile();
		for (clsBankClient& C : _vClients)
		{
			if (C.AccountNumber() == _AccountNumber)
			{
				C._MarkedForDelete = true;
				break;
			}
		}
		_SaveClientsDataToFile(_vClients);
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
};

