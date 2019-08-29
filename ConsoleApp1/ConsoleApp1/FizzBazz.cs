using System;
using System.Collections.Generic;

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
            Dictionary<int,string> test= new Dictionary<int, string>()
            {
                { 3,"Fizz"},{5,"Bazz"}
            };
            foreach (var item in test)
            {
                if (v % item.Key == 0)
                {
                    result += item.Value;
                }
            }
            if (result == "")
            {
                result = v.ToString();
            }

            //if (v % 3 == 0)
            //{
            //    result += "Fizz";
            //}
            //if (v % 5 == 0)
            //{
            //    result += "Bazz";
            //}
            //if (result == "")
            //{
            //    result = v.ToString();
            //}
            return result;
        }
    }
}