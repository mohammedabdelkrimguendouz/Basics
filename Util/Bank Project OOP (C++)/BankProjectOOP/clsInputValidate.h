#pragma once
#include<iostream>
#include<string>
#include"clsString.h"
#include"clsDate.h"
#include"clsPeriod.h"
using namespace std;
class clsInputValidate
{
public:
	template<typename T> static bool IsNumberBetween(T Number, T From,T To )
	{
		return (Number >= From && Number <= To);
	}
	static bool IsDateBetween(clsDate Date, clsDate DateFrom, clsDate DateTo)
	{
		if (clsDate::IsDate1AfterDate2(DateFrom, DateTo))
			clsDate::SwapDates(DateFrom, DateTo);
		return clsPeriod::IsDateInPeriod(clsPeriod(DateFrom, DateTo), Date);
	}
	template<typename T> static T ReadString()
	{
		T Str;
		getline(cin>>ws, Str);
		return Str;
	}
	template<typename T> static T ReadNumber(string ErrorMessage = "Invalide Number, Enter agine:")
	{
		T Number;
		cin >> Number;
		while (cin.fail())
		{
			cin.clear();
			cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			cout << ErrorMessage;
			cin >> Number;
		}
		return Number;
	}
	template<typename T>static T ReadNumberBetween(T From, T To, string ErrorMessage = "Number is not within range, enter agine:")
	{
		T Number = ReadNumber<T>();
		while (!IsNumberBetween<T>(Number, From, To))
		{
			cout << ErrorMessage;
			Number = ReadNumber<T>();
		}
		return Number;
	}
	static bool IsValideDate(clsDate Date)
	{
		return clsDate::IsValidDate(Date);
	}
};

