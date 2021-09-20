using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    class PasswordChecker
    {
        static int MIN_LENGTH = 6;
        static int MAX_LENGTH = 24;

        char[] password = new char[MAX_LENGTH];

        char[] Uppercases = new char[] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        char[] Lowercases = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] Numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] SpecialChar = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=', '_', '-', '{', '}', '[', ']', ':', ';', '"', '?', '<', '>', ',', '.', ' '};

        public bool CheckPW(string password)
        {
            if (password.Length < MIN_LENGTH)
            {
                Console.WriteLine("Password is too short!");
                return false;
            }
            else if (password.Length > MAX_LENGTH)
            {
                Console.WriteLine("Password is too long!");
                return false;
            }
            foreach (char c in password)
            {
                if (!Char.IsUpper(c))
                {
                    Console.WriteLine("Password requires a minimum of 1 UPPERCASE character!");
                    return false;
                }
            }
            foreach (char c in password)
            {
                if (!Char.IsLower(c))
                {
                    Console.WriteLine("Password requires a minimum of 1 LOWERCASE character!");
                    return false;
                }
            }
            foreach (char c in password)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Password requires a minimum of 1 NUMBER character!");
                    return false;
                }
            }
            foreach (char c in password)
            {
                if (!Char.IsSymbol(c))
                {
                    Console.WriteLine("Password requires a minimum of 1 SPECIAL character!");
                    return false;
                }
            }
            Console.WriteLine("Your password is good to go!");
            return true;
                
        }
    }
     class Program
    {
        
        static void Main(string[] args)
        {
            PasswordChecker pw = new PasswordChecker();
            pw.CheckPW("Aho15@fafaa$%A");
            Console.ReadLine();
        }
    }
}
