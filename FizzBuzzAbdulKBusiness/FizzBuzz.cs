using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAbdulKBusiness
{
    public class FizzBuzz : IFizzBuzz
    {

        public string GenerateFizzBuzz(int number)
        {
            string retFizzBuzz = number.ToString();

            if (number % 3 == 0)
                retFizzBuzz = "fizz".ToTitleCase();

            if (number % 5 == 0)
                retFizzBuzz = "buzz".ToTitleCase();

            if (number % 3 == 0 && number % 5 == 0)
                retFizzBuzz = "fizzbuzz".ToTitleCase();

            return retFizzBuzz;
        }

    }


    //extension method....
    public static class StringManiplutionExt
    {
        public static string ToTitleCase(this string value)
        {
            //string test = value;
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
    }
}
