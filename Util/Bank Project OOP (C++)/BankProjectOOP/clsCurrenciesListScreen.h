#pragma once
#include"iostream"
#include<iomanip>
#include"clsCurrency.h"
#include"clsScreen.h"
using namespace std;
class clsCurrenciesListScreen:protected clsScreen
{
private:
    static void _PrintCurrency(clsCurrency Currency)
    {
        cout << setw(8) << left << "" << "| " << setw(30) << left << Currency.Country();
        cout << "| " << left << setw(8) << Currency.CurrencyCode();
        cout << "| " << left << setw(45) << Currency.CurrencyName();
        cout << "| " << left << setw(10) << Currency.Rate();
    }
public:
	static void ShowCurrenciesListScreen()
	{
        vector<clsCurrency> vCurrencys = clsCurrency::GetCurrenciesList();
        string Title = "\tCurrencies List Screen";
        string SubTitle = "\t   (" + to_string(vCurrencys.size()) + ") Currency.";
        _DrawScreenHeader(Title, SubTitle);
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        cout << setw(8) << left << "" << "| " << setw(30) << left << "Country";
        cout << "| " << left << setw(8) << "Code";
        cout << "| " << left << setw(45) << "Name";
        cout << "| " << left << setw(10) << "Rate/(1$)";
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        if (vCurrencys.size() == 0)
        {
            cout << "\t\t\t\tNo Currencies Available In The System!";
        }
        else
        {
            for (clsCurrency Currency : vCurrencys)
            {
                _PrintCurrency(Currency);
                cout << endl;
            }
        }
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________" << endl;
    }
};

