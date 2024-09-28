#pragma once
#include<iostream>
#include<string>
#include"clsDate.h"
using namespace std;

class clsUtil
{
public:
	static void Srand()
	{
		srand((unsigned)time(NULL));
	}
	static int RandomNumber(int From, int To)
	{
		return rand() % (To - From + 1) + From;
	}
	enum enCharType{SmallLetter=1,CapitalLetter=2,Digit=3,MixChars=4, SpecialCharacter = 5};
	static char GetRandomCharacter(enCharType CharType)
	{
		if (CharType == enCharType::MixChars)
		{
			CharType =(enCharType) RandomNumber(1, 3);
		}
		switch (CharType)
	    {
		    case enCharType::SmallLetter:
		    {
			     return char(RandomNumber(97, 122));
			     break;
		    }
		    case enCharType::CapitalLetter:
		    {
			    return char(RandomNumber(65, 90));
			    break;
		    }
		    case enCharType::Digit:
		    {
			    return char(RandomNumber(48, 57));
			    break;
		    }
			case enCharType::SpecialCharacter:
			{
				return char(RandomNumber(33, 47));
				break;
			}
		    defualt:
			{
				return char(RandomNumber(65, 90));
				break;
			}
	    }

	}
	static string GenerateWord(enCharType CharType, short Length)
	{
		string Word = "";
		for (short i = 1; i <= Length; i++)
		{
			Word += GetRandomCharacter(CharType);
		}
		return Word;
	}
	static string GenerateKey(enCharType CharType = CapitalLetter)
	{
		string Key = "";
		Key += GenerateWord(CharType, 4)+'-';
		Key += GenerateWord(CharType, 4) + '-';
		Key += GenerateWord(CharType, 4) + '-';
		Key += GenerateWord(CharType, 4);
		return Key;
	}
	static void GenerateKeys(enCharType CharType,short NumberOfKeys)
	{
		for (short i = 1; i <= NumberOfKeys; i++)
		{
			cout << "Key [" << i << "] : ";
			cout << GenerateKey(CharType)<<endl;
		}
	}
	static void Swap(int& Number1, int& Number2)
	{
		int Temp = Number1;
		Number1 = Number2;
		Number2= Temp;
	}
	static void Swap(string& S1, string& S2)
	{
		string Temp = S1;
		S1 = S2;
		S2 = Temp;
	}
	static void Swap(double& Number1, double& Number2)
	{
		double Temp = Number1;
		Number1 = Number2;
		Number2 = Temp;
	}
	static void Swap(char& Char1, char& Char2)
	{
		char Temp = Char1;
		Char1 = Char2;
		Char2 = Temp;
	}
	static void Swap(bool& Bool1, bool& Bool2)
	{
		bool Temp = Bool1;
		Bool1 = Bool2;
		Bool2 = Temp;
	}
	static void Swap(clsDate& Date1,clsDate& Date2)
	{
		clsDate::SwapDates(Date1, Date2);
	}
	static void ShuffleArray(int Array[], int arrLength)
	{
		for (int i = 0; i < arrLength; i++)
		{
			Swap(Array[RandomNumber(1, arrLength)-1], Array[RandomNumber(1, arrLength)-1]);
		}
	}
	static void ShuffleArray(string Array[], int arrLength)
	{
		for (int i = 0; i < arrLength; i++)
		{
			Swap(Array[RandomNumber(1, arrLength) - 1], Array[RandomNumber(1, arrLength) - 1]);
		}
	}
	static void FillArrayWithRandomNumbers(int Array[], int arrLength, int From, int To)
	{
		for (int i = 0; i < arrLength; i++)
		{
			Array[i] = RandomNumber(From, To);
		}
	}
	static void FillArrayWithRandomWords(string Array[], int arrLength, enCharType CharType, short WordLength)
	{
		for (int i = 0; i < arrLength; i++)
		{
			Array[i] = GenerateWord(CharType, WordLength);
		}
	}
	static void FillArrayWithRandomKeys(string Array[], int arrLength, enCharType CharType)
	{
		for (int i = 0; i < arrLength; i++)
		{
			Array[i] = GenerateKey(CharType);
		}
	}
	static string Tabs(short NumberOfTabs)
	{
		string Tab = "";
		for (int i = 0; i < NumberOfTabs; i++)
		{
			Tab += "\t";
			cout << Tab;
		}
		return Tab;
	}
	static string EncryptText(string Text, short EncryptionKey=2)
	{
		for (int i = 0; i < Text.length(); i++)
		{
			Text[i] = char(int(Text[i]) + EncryptionKey);
		}
		return Text;
	}
	static string DecryptText(string Text, short EncryptionKey=2)
	{
		for (int i = 0; i < Text.length(); i++)
		{
			Text[i] = char(int(Text[i]) - EncryptionKey);
		}
		return Text;
	}
	static int DecimailToBinaire(int Number)
	{
		int Binaire_Number = 0, Base = 1;
		while (Number > 0)
		{
			int Rem = Number % 2;
			Binaire_Number = Binaire_Number + Rem * Base;
			Base = Base * 10;
			Number = Number / 2;
		}
		return Binaire_Number;
	}
	static string NumberToText(int Number)
	{
		if (Number == 0) return "";
		if (Number >= 1 && Number <= 19)
		{
			string arr[] = { "","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
			"Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Ninteen" };
			return arr[Number] + " ";
		}
		if (Number >= 20 && Number <= 99)
		{
			string arr[] = { "","","Twenty","Thirty","Forty","Fifty","Sixty","Seventy","Eighty","Ninety" };
			return arr[Number / 10] + " " + NumberToText(Number % 10);
		}
		if (Number >= 100 && Number <= 199)
		{
			return  "One Hundred " + NumberToText(Number % 100);
		}
		if (Number >= 200 && Number <= 999)
		{
			return NumberToText(Number / 100) + "Hundred " + NumberToText(Number % 100);
		}
		if (Number >= 1000 && Number <= 1999)
		{
			return "One Thousands " + NumberToText(Number % 1000);
		}
		if (Number >= 2000 && Number <= 999999)
		{
			return NumberToText(Number / 1000) + "Thousands " + NumberToText(Number % 1000);
		}
		if (Number >= 1000000 && Number <= 1999999)
		{
			return  "One Million " + NumberToText(Number % 1000000);
		}
		if (Number >= 2000000 && Number <= 999999999)
		{
			return NumberToText(Number / 1000000) + "Million " + NumberToText(Number % 1000000);
		}
		if (Number >= 1000000000 && Number <= 1999999999)
		{
			return "One Billion " + NumberToText(Number % 1000000000);
		}
		else
			return NumberToText(Number / 1000000000) + "Billion " + NumberToText(Number % 1000000000);

	}
	static int ReverseNumbre(int Number)
	{
		int Remainder = 0, Number2 = 0;
		while (Number > 0)
		{
			Remainder = Number % 10;
			Number = Number / 10;
			Number2 = Number2 * 10 + Remainder;
		}
		return Number2;
	}
};

