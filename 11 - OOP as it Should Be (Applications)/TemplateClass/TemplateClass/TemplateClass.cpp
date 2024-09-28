
#include <iostream>
using namespace std;
template<class T>
class clsCalulator
{
private:
	T Number1, Number2;
public:
	clsCalulator(T n1, T n2)
	{
		Number1 = n1;
		Number2 = n2;
	}
	void PrintResults()
	{
		cout << "Number: " << Number1 << " and " << Number2 << "\n\n";
		cout << Number1 << " + " << Number2 << " = " << Add() << endl;
		cout << Number1 << " - " << Number2 << " = " << SubTract() << endl;
		cout << Number1 << " * " << Number2 << " = " << Multiplay() << endl;
		cout << Number1 << " / " << Number2 << " = " << Divide() << endl;
	}
	T Add()
	{
		return Number1 + Number2;
	}
	T SubTract()
	{
		return Number1 - Number2;
	}
	T Multiplay()
	{
		return Number1 * Number2;
	}
	T Divide()
	{
		return Number1 / Number2;
	}

};

int main()
{
	clsCalulator<int> intCalc(2, 5);
	intCalc.PrintResults();
	cout << endl;
	clsCalulator<double> floatCalc(6.94, 3.2);
	floatCalc.PrintResults();
    return 0;
}


