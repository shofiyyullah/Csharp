using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intermediate.Utils;

namespace Intermediate.Models
{
    class ExplodeNumber : MathNumber, IExplodeNumber
    {
        public void explodeNumber(int number)
        {
            numberInput = number.ToString(); // var number input from base class

            int digit = numberInput.Length;
            char[] charNumber = numberInput.ToCharArray();

            for (int i = 0; i < digit; i++)
            {
                string newNumberOther = charNumber[i] + trailingZero(digit - (i + 1), "#"); //overloading
                printToConsole(newNumberOther);
            }

            Console.WriteLine();

            for (int i = 0; i < digit; i++)
            {
                string newNumberOther = charNumber[i] + trailingZero(digit - (i + 1)); //overidding
                printToConsole(newNumberOther);
            }
        }

        public void printToConsole(string number)
        {
            Console.WriteLine(number);
        }

        //overriding
        public override string trailingZero(int size)
        {
            string zeros = "";
            int i = 0;
            while (i < size)
            {
                zeros += "0";
                i++;
            }

            return zeros;
        }
        
    }
}