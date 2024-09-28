using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classLibraryUtil
{
    public class clsUtil
    {
        public static int RandomNumber(int From, int To)
        {
            Random rand = new Random();
            return rand.Next(From, To);
        }

        public static bool IsNumberBetween<T>(T Number, T From, T To) where T : IComparable<T>
        {
            return (Number.CompareTo(From) >= 0 && Number.CompareTo(To) <= 0);
        }


        public static int ReadNumberBetween(int From, int To, string ErrorMessage = "Number is not within range, enter agine:")
        {
            string Inpute = Console.ReadLine();
            int Number;
            while (!int.TryParse(Inpute, out Number)|| !IsNumberBetween<int>(Number, From, To))
            {
                Console.Write(ErrorMessage);
                Inpute = Console.ReadLine();
            }
            return Number;
        }
        public static double RandomNumber(double From, double To)
        {
            Random rand = new Random();
            return rand.NextDouble() * (To - From) + From;
        }

        public  enum enCharType { SmallLetter = 1, CapitalLetter = 2, Digit = 3, MixChars = 4, SpecialCharacter = 5 };
        public static char GetRandomCharacter(enCharType CharType)
        {
            if (CharType == enCharType.MixChars)
            {
                CharType = (enCharType)RandomNumber(1, 4);
            }
            switch (CharType)
            {
                case enCharType.SmallLetter:
                    {
                        return (char)(RandomNumber(97, 123));

                    }
                case enCharType.CapitalLetter:
                    {
                        return (char)(RandomNumber(65, 91));

                    }
                case enCharType.Digit:
                    {
                        return (char)(RandomNumber(48, 58));

                    }
                case enCharType.SpecialCharacter:
                    {
                        return (char)(RandomNumber(33, 48));

                    }
            }
            return (char)(RandomNumber(65, 91));
        }
        public static string GenerateWord(enCharType CharType, int Length)
        {
            string Word = "";
            for (short i = 1; i <= Length; i++)
            {
                Word += GetRandomCharacter(CharType);
            }
            return Word;
        }
        public static string GenerateKey(enCharType CharType = enCharType.CapitalLetter)
        {
            string Key = "";
            Key += GenerateWord(CharType, 4) + '-';
            Key += GenerateWord(CharType, 4) + '-';
            Key += GenerateWord(CharType, 4) + '-';
            Key += GenerateWord(CharType, 4);
            return Key;
        }
        public static void GenerateKeys(enCharType CharType, short NumberOfKeys)
        {
            for (short i = 1; i <= NumberOfKeys; i++)
            {
                Console.Write($"Key [  {i}  ] : ");
                Console.WriteLine(GenerateKey(CharType));
            }
        }
        public static void Swap<T>(ref T Number1, ref T Number2)
        {
            T Temp = Number1;
            Number1 = Number2;
            Number2 = Temp;
        }
        

        public static void ShuffleArray<T>(T[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Swap(ref Array[RandomNumber(1, Array.Length) - 1], ref Array[RandomNumber(1, Array.Length) - 1]);
            }
        }
        
        public static void FillArrayWithRandomNumbers(int[] Array, int From, int To)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = RandomNumber(From, To);
            }
        }
        public static void FillArrayWithRandomWords(string[] Array, enCharType CharType, int WordLength)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = GenerateWord(CharType, WordLength);
            }
        }
        public static void FillArrayWithRandomKeys(string[] Array, enCharType CharType)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = GenerateKey(CharType);
            }
        }
        public static string Tabs(short NumberOfTabs)
        {
            string Tab = "";
            for (int i = 0; i < NumberOfTabs; i++)
            {
                Tab += "\t";
            }
            return Tab;
        }
        public static string EncryptText(string Text, int EncryptionKey = 2)
        {
            string TextEncrypt = "";
            for (int i = 0; i < Text.Length; i++)
            {
                TextEncrypt = TextEncrypt + (char)((int)(Text[i]) + EncryptionKey);
            }
            return TextEncrypt;
        }
        public static string DecryptText(string Text, int EncryptionKey = 2)
        {
            string TextDecrypt = "";
            for (int i = 0; i < Text.Length; i++)
            {
                TextDecrypt=TextDecrypt+ (char)((int)(Text[i]) - EncryptionKey);
            }
            return TextDecrypt;
        }
        public static int DecimailToBinaire(int Number)
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
        public static string NumberToText(int Number)
        {
            if (Number == 0) return "";
            if (Number >= 1 && Number <= 19)
            {
                string[] arr = { "","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
            "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Ninteen" };
                return arr[Number] + " ";
            }
            if (Number >= 20 && Number <= 99)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                return arr[Number / 10] + " " + NumberToText(Number % 10);
            }
            if (Number >= 100 && Number <= 199)
            {
                return "One Hundred " + NumberToText(Number % 100);
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
                return "One Million " + NumberToText(Number % 1000000);
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
    }
}
