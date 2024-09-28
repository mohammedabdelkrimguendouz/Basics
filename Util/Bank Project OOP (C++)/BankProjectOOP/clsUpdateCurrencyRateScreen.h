#pragma once
#include"iostream"
#include<iomanip>
#include"clsCurrency.h"
#include"clsScreen.h"
#include"clsInputValidate.h"
using namespace std;
class clsUpdateCurrencyRateScreen:protected clsScreen
{
private:
    static float _ReadRate()
    {
        float NewRate;
        cout << "Enter New Rate : ";
        NewRate = clsInputValidate::ReadNumber<float>();
        return NewRate;
    }
    static void _PrintCurrency(clsCurrency Currency)
    {
        cout << "\nCurrency Card: ";
        cout << "\n_____________________________\n";
        cout << "\nCountry    : " << Currency.Country();
        cout << "\nCode       : " << Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : " << Currency.Rate();
        cout << "\n______________________________\n";
    }
public:
    static void ShowUpdateCurrencyRateScreen()
    {
        _DrawScreenHeader("\tUpdate Currency Screen");
        string CurrencyCode;
        cout << "\nPlease Enter Currency Code : ";
        CurrencyCode = clsInputValidate::ReadString<string>();
        while (!clsCurrency::IsCurrencyExist(CurrencyCode))
        {
            cout << "\nCurrency is not found,Choose anthor one : ";
            CurrencyCode = clsInputValidate::ReadString<string>();
        }
        clsCurrency Currency = clsCurrency::FindByCode(CurrencyCode); 
        _PrintCurrency(Currency);
        char Answer = 'n';
        cout << "\nAre you sure yoy want to update the rate of this currency Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            cout << "\n\nUpdate Currency Rate :";
            cout << "\n___________________________\n";
            Currency.UpdateRate(_ReadRate());
            cout << "\nCurrency Rate Updated Successfully :-)";
            _PrintCurrency(Currency);
        }
       
    }
};

