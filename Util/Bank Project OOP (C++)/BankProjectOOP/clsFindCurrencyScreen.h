#pragma once
#include"iostream"
#include<iomanip>
#include"clsCurrency.h"
#include"clsScreen.h"
#include"clsInputValidate.h"
using namespace std;
class clsFindCurrencyScreen:protected clsScreen
{
private:
    enum enTypeFindCurrency
    {
        FindByCode = 1,
        FindByCountry=2
    };
    static short _ReadTypeFindCurrency()
    {
        cout << "Find By : [1] Code or [2] Country ?";
        return clsInputValidate::ReadNumberBetween<short>(1, 2, "Enter Number 1 or 2 : ");
    }
    static void _PrintCurrency(clsCurrency Currency)
    {
        cout << "\nCurrency Card: ";
        cout << "\n_____________________________\n";
        cout << "\nCountry    : "<<Currency.Country();
        cout << "\nCode       : "<< Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : "<< Currency.Rate();
        cout << "\n______________________________\n";
    }
    static clsCurrency _FindByCode()
    {
        cout << "\nPlease Enter Currency Code : ";
        string CurrencyCode = clsInputValidate::ReadString<string>();
        return clsCurrency::FindByCode(CurrencyCode);
    }
    static clsCurrency _FindByCountry()
    {
        cout << "\nPlease Enter Country : ";
        string Country =clsInputValidate::ReadString<string>();
        return clsCurrency::FindByCountry(Country);
    }
    static clsCurrency _PerformTypeFindCurrency(enTypeFindCurrency TypeFindCurrency)
    {
        switch (TypeFindCurrency)
        {
        case enTypeFindCurrency::FindByCode:
            return _FindByCode();
        case enTypeFindCurrency::FindByCountry:
            return _FindByCountry();
        }
    }
public:
    static void ShowFindCurrencyScreen()
    {
        _DrawScreenHeader("\tFind Currency Screen");
        clsCurrency Currency = _PerformTypeFindCurrency((enTypeFindCurrency)_ReadTypeFindCurrency());
        if (!Currency.IsEmpty())
        {
            cout << "\nCurrency  Found -) \n";
            _PrintCurrency(Currency);
        }
        else
        {
            cout << "\nCurrency was not Found -( \n";
        }
    }
};

