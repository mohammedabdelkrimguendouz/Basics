#include <iostream>
using namespace std;

class clsPerson
{
	string _FullName;
	class clsAdress
	{
	private:
		string _AdressLine1;
		string _AdressLine2;
		string _city;
	public:
		clsAdress(string AdressLine1, string AdressLine2, string City)
		{
			_AdressLine1 = AdressLine1;
			_AdressLine2 = AdressLine2;
			_city = City;
		}
		void SetAdressLine1(string AdressLine1)
		{
			_AdressLine1 = AdressLine1;
		}
		string AdressLine1()
		{
			return _AdressLine1;
		}
		void SetAdressLine2(string AdressLine2)
		{
			_AdressLine2 = AdressLine2;
		}
		string AdressLine2()
		{
			return _AdressLine2;
		}
		void SetCity(string city)
		{
			_city = city;
		}
		string city()
		{
			return _city;
		}
		void Print()
		{
			cout << _AdressLine1 << endl;
			cout << _AdressLine2 << endl;
			cout << _city << endl;
		}
	};
public:
		void SetFullName(string FullName)
		{
			_FullName = FullName;
		}
		string FullName()
		{
			return _FullName;
		}
		clsAdress Adress = clsAdress("", "", "");
		clsPerson(string FullName, string AdressLine1, string AdressLine2, string City)
		{
			_FullName = FullName;
			Adress = clsAdress(AdressLine1, AdressLine2, City);
		}
};

int main()
{
	clsPerson Person("karim","alg","ouargla","sokra");
	Person.Adress.Print();
    return 0;
}