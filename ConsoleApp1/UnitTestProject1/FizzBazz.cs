using System;

namespace UnitTestProject1
{
    internal class FizzBazz
    {
        public FizzBazz()
        {
        }

        internal string Calculate(int v)
        {
            var result = string.Empty;
            if (v % 3 == 0)
            {
                result += "Fizz";
            }
            if (v % 5 == 0)
            {
                result += "Bazz";
            }

            if (result == "")
            {
                result=v.ToString();
            }
            return result;
        }
    }
}