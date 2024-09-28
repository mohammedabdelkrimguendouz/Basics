using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing_Example
{
    internal class Program
    {
        public static string ComputeHash(string Input)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] HashBytes=sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));
                return BitConverter.ToString(HashBytes).Replace("-","").ToLower();
            }
        }
        static void Main(string[] args)
        {
            string Data = "1234";
            string HashData = ComputeHash(Data);
            Console.WriteLine("data               : " + Data);
            Console.WriteLine("data hashed        : " + HashData);
            Console.WriteLine("data hashed length : " + HashData.Length);

            Console.ReadKey();
        }
    }
}
