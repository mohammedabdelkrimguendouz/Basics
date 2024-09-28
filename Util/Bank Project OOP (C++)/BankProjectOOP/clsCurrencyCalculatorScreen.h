#pragma once
#include<iostream>
#include"clsCurrency.h"
#include"clsScreen.h"
#include"clsInputValidate.h"
using namespace std;
class clsCurrencyCalculatorScreen:protected clsScreen
{
private:
    static void _PrintCurrencyCard(clsCurrency Currency,string Title="Currency Card:")
    {
        cout <<"\n" << Title<<"\n";
        cout << "_____________________________\n";
        cout << "\nCountry    : " << Currency.Country();
        cout << "\nCode       : " << Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : " << Currency.Rate();
        cout << "\n______________________________\n\n";
    }
    static void _PrintCalculationResult(float Amount, clsCurrency Currency1,clsCurrency Currency2)
    {
        _PrintCurrencyCard(Currency1, "Convert From : ");
        float AmountInUSD = Currency1.ConvertToUSD(Amount);
        cout << Amount << " " << Currency1.CurrencyCode() << " = " <<
            AmountInUSD << " " << "USD\n";
        if (Currency2.CurrencyCode() == "USD") return;
        cout << "\nConvert From USD to : \n";
        _PrintCurrencyCard(Currency2, "To:");
        float AmounInCurrency2 = Currency1.ConvertToOtherCurrency(Amount, Currency2);
        cout << Amount << " " << Currency1.CurrencyCode() << " = " <<
            AmounInCurrency2 << " " << Currency2.CurrencyCode();
    }
    static clsCurrency _GetCurrency(string Message)
    {
        cout << Message<<endl;
        string CurrencyCode = clsInputValidate::ReadString<string>();
        while (!clsCurrency::IsCurrencyExist(CurrencyCode))
        {
            cout << "\nCurrency is not found,Choose anthor one : ";
            CurrencyCode = clsInputValidate::ReadString<string>();
        }
        clsCurrency Currency = clsCurrency::FindByCode(CurrencyCode);
        return Currency;
    }
    static float _ReadAmount()
    {
        cout << "\nEnter Amount to Exchange : ";
        return clsInputValidate::ReadNumber<float>();
    }
public:
	static void ShowCurrencyCalculatorScreen()
	{
        char Countinue = 'y';
        while (Countinue=='y'||Countinue=='Y')
        {
            system("cls");
            _DrawScreenHeader("\tCalculator Currency Screen");
            clsCurrency CurrencyFrom = _GetCurrency("\nPlease Enter Currency1 Code:");
            clsCurrency CurrencyTo = _GetCurrency("\nPlease Enter Currency2 Code:");
            float Amount = _ReadAmount();
            _PrintCalculationResult(Amount, CurrencyFrom, CurrencyTo);
            cout << "\n\nDo you want to perform anthor calculation ? Y/N ?";
            cin >>Countinue;
        }
	}
};

