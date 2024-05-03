using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    public class Validator
    {
        public static bool IsIdValid(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput)) return false;

            foreach (char c in stringInput)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine("Your drink choice should be a number, not the name of the drink");
                    return false;
                }
            }

            return true;
        }

        internal static bool IsStringValid(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput)) return false;

            foreach (char c in stringInput)
            {
                if (!Char.IsLetter(c) && c!= '/' && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
