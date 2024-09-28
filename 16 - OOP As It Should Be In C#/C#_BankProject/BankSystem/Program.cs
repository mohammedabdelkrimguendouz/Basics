using System;
using classLibraryUtil;
using System.Collections.Generic;
using System.Security.Policy;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (!clsLoginScreen.ShowLogin())
                {
                    break;
                }

            }
        }
    }
}
