using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Utils
{
    class MathNumber
    {
        protected string numberInput;

        // overrided
        public virtual string trailingZero(int size)
        {
            string zeros = "";
            for (int i = 0; i < size; i++)
            {
                zeros += "0";
            }

            return zeros;
        }

        // overloading
        public string trailingZero(int size, string symbol)
        {
            string zeros = "";
            for (int i = 0; i < size; i++)
            {
                zeros += symbol;
            }

            return zeros;
        }
    }
}
