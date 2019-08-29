using System;

namespace ConsoleApp1
{
    public class FizzBazz
    {
        public FizzBazz()
        {
        }

        public string Calculate(int v)
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
                result = v.ToString();
            }
            return result;
        }
    }
}