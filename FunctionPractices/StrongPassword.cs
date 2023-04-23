using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class StrongPassword
    {
        public static void GenerateStrongPassword()
        {
            // Define the character sets to use for each password requirement
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string symbolChars = "!@#$%^&*()-_=+[]{}\\|;:'\",.<>/?";

            // Combine the character sets into a single set of all possible characters
            string allChars = uppercaseChars + lowercaseChars + numberChars + symbolChars;

            // Generate a random password that meets the requirements
            StringBuilder passwordBuilder = new StringBuilder();
            Random random = new Random();
            while (passwordBuilder.Length < 12 || !ContainsUpperCase(passwordBuilder) || !ContainsLowerCase(passwordBuilder) || !ContainsNumber(passwordBuilder) || !ContainsSymbol(passwordBuilder))
            {
                int index = random.Next(allChars.Length);
                char randomChar = allChars[index];
                passwordBuilder.Append(randomChar);
            }
            string password = passwordBuilder.ToString();

            // Print the password to the console
            Console.WriteLine("Generated password: {0}", password);
        }

        static bool ContainsUpperCase(StringBuilder sb)
        {
            foreach (char c in sb.ToString())
            {
                if (Char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsLowerCase(StringBuilder sb)
        {
            foreach (char c in sb.ToString())
            {
                if (Char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsNumber(StringBuilder sb)
        {
            foreach (char c in sb.ToString())
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsSymbol(StringBuilder sb)
        {
            foreach (char c in sb.ToString())
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
