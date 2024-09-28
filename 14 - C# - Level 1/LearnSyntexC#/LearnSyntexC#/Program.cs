
using System;// include <iostram>
using System.Linq;
namespace LearnSyntexC_
{
    internal class Program
    {
        enum enWeek
        {
            a = 1,
            b = 2
        };
        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Karim geundouz !\n");
            Console.WriteLine("Karim geundouz !");
            Console.Write("10 + 20 = " + 10 + 20+"\n");
            Console.WriteLine("10 + 20 = " + (10 + 20));
            Console.WriteLine("{0} {1}", "Welcome to ", "Programming Advices");
            Console.WriteLine("Hi My Name is : {0} I live In {1} {2}", "karim", "Jordan","UAS");
            */
            // \n,\t,\b,\',\",\\,\a
            // Nullable<int> i = null;
            /* enWeek Week; // enum 
             Week = enWeek.a;
             Console.WriteLine(Week);
             var Student = new
             {
                 Id = 20,
                 FirstName = "karim",
                 Adress = new { City = "Amman", Country = "Jordan" }
             };
             Console.WriteLine(Student); // { Id = 20, FirstName = karim, Adress = { City = Amman, Country = Jordan } }
             Console.WriteLine(Student.FirstName);//Karim
             Console.WriteLine(Student.Adress.Country);
             //Student.Adress = "algeria"; //Errore
             // This type are read only // للقراءة فقط لاتستطيع التعديل عل القيم 
             var S1 = Student;
             Console.WriteLine(S1);
            */
            /*
            stStudent Student;
            stStudent Student2 = new stStudent();
            Student.FirstName = "karim";
            Student2.FirstName = "ali";
            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student.FirstName);
            */
            /* dynamic dy = 100;
             Console.WriteLine(dy.GetType());
             dy = "karim";
             Console.WriteLine(dy.GetType());
             dy = true;
             Console.WriteLine(dy.GetType());
             dy =DateTime.Now;
             Console.WriteLine(dy.GetType());
            */
            /*int x = 1;
            Console.WriteLine(x);
            x &= 2; 
            Console.WriteLine(x);
            x |= 2;
            Console.WriteLine(x);
            x ^= 2; //Bitwise  Xor // جدول الحقيقة نفس القيمة النتيجة0 
            Console.WriteLine(x); // تخريك اكبر بت الى اليسار 
            x <<= 5; // x<<=5;// x=5^2*x;
            Console.WriteLine(x);//تخريك اصغر بت الى اليمين 
            x >>= 5;// x>>5// x=5^2/x;
            Console.WriteLine(x);
            */
            /*
            int number = 10, result;
            bool flag = true;

            result = +number; //result = number * 1;
            Console.WriteLine("+number = " + result);

            result = -number;// result=number*-1;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));
            */
            /*
             int number = 12;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
             */
            /*
             char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
             */
            /*
             isEven = (number % 2 == 0) ? true : false ;
             */
            /*//assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(DateTime.Now); 
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);

            DateTime dt5 = new DateTime(2023, 2, 21);
            DateTime dt6 = new DateTime(2023, 2, 25);
            TimeSpan result = dt6.Subtract(dt5);

            Console.WriteLine(result.Days);
            
            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//True
            
            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str,out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");
            */
            string S1 = "Mohammed Abu-Hadhoud";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
