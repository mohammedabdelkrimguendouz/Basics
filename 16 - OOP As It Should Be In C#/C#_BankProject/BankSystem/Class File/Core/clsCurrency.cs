using System;
using System.Collections.Generic;
using System.IO;


namespace BankSystem
{
    public class clsCurrency
    {
        public string Country {  get; }

        public string CurrencyCode {  get; }
        public string CurrencyName { get; }

        private double _Rate;
        public double Rate()
        {
            return _Rate;
        }

        static private string _PathFileCurrencies = "C:\\Users\\KarimPc\\Desktop\\C#_BankProject\\BankSystem\\Currencies.txt";
        public clsCurrency(string country, string currencyCode, string currencyName, double rate)
        {
            Country = country;
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
            _Rate = rate;
        }
        private static clsCurrency _ConvertLineToCurrencyObject(string Line, string Separator = "#//#")
        {
            string[] Separators = new string[] { Separator };
            string[] arrCurrency = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            clsCurrency Currency = new clsCurrency(arrCurrency[0], arrCurrency[1], arrCurrency[2],Convert.ToDouble(arrCurrency[3]));
                 
            return Currency;
        }

        private static string _ConvertCurrencyObjectToLine(clsCurrency Currency, string Separator = "#//#")
        {
            string LineCurrency = "";
            LineCurrency += Currency.Country + Separator;
            LineCurrency += Currency.CurrencyCode + Separator;
            LineCurrency += Currency.CurrencyName + Separator;
            LineCurrency += Currency.Rate();
            
            return LineCurrency;
        }

        private static List<clsCurrency> _LoadCurrencyDataFromFile()
        {
            List<clsCurrency> _ListCurrency = new List<clsCurrency>();
            if (File.Exists(_PathFileCurrencies))
            {
                StreamReader MyFile = new StreamReader(_PathFileCurrencies);
                string Line;

                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsCurrency Currency = _ConvertLineToCurrencyObject(Line);
                    _ListCurrency.Add(Currency);
                }
                MyFile.Close();
            }
            return _ListCurrency;
        }

        private static void _SaveCurrenciesDataToFile(List<clsCurrency> Currencies)
        {
            if (File.Exists(_PathFileCurrencies))
            {
                StreamWriter MyFile = new StreamWriter(_PathFileCurrencies);
                string DataLine;
                foreach (clsCurrency Currency in Currencies)
                {
                        DataLine = _ConvertCurrencyObjectToLine(Currency);
                        MyFile.WriteLine(DataLine);
                }
                MyFile.Close();
            }
        }

        private void _Update()
        {
            List<clsCurrency> _ListCurrencies = _LoadCurrencyDataFromFile();
            for(int i=0;i< _ListCurrencies.Count;i++)
            {
                if (_ListCurrencies[i].CurrencyCode==CurrencyCode)
                {
                    _ListCurrencies[i] = this;
                    break;
                }
            }
            _SaveCurrenciesDataToFile(_ListCurrencies);
        }
        public void UpdateRate(double NewRate)
        {
            _Rate = NewRate;
            _Update();
        }

        static public clsCurrency FindByCode(string CurrencyCode)
        {
            if (File.Exists(_PathFileCurrencies))
            {
                CurrencyCode = CurrencyCode.ToUpper();
                StreamReader MyFile = new StreamReader(_PathFileCurrencies);
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsCurrency Currency = _ConvertLineToCurrencyObject(Line);
                    if (Currency.CurrencyCode.ToUpper()==CurrencyCode)
                    {
                        MyFile.Close();
                        return Currency;
                    }
                }
                MyFile.Close();
            }

            return null;
        }
        static public clsCurrency FindByCountry(string Country)
        {
            if (File.Exists(_PathFileCurrencies))
            {
                Country = Country.ToUpper();
                StreamReader MyFile = new StreamReader(_PathFileCurrencies);
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsCurrency Currency = _ConvertLineToCurrencyObject(Line);
                    if (Currency.Country.ToUpper() == Country)
                    {
                        MyFile.Close();
                        return Currency;
                    }
                }
                MyFile.Close();
            }

            return null;
        }

        public static bool IsCurrencyExist(string CurrencyCode)
        {
            return !(FindByCode(CurrencyCode) == null);
        }
        public static List<clsCurrency> GetCurrenciesList()
        {
            return _LoadCurrencyDataFromFile();
        }

         public double ConvertToCurrency( clsCurrency CurrencyTo, double AmountExchange)
        {
            if(CurrencyCode=="USD")
                return AmountExchange * CurrencyTo.Rate();
            else if(CurrencyTo.CurrencyCode=="USD")
                return AmountExchange / Rate();

            double  AmountInUSD= AmountExchange / Rate();
            return AmountInUSD * CurrencyTo.Rate();

             
        }
        
    }
}
