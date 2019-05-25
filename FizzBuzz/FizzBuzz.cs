using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            //if (IsMultipleOf3(num) && IsMultipleOf5(num))
            //{
            //    return "Fizz Buzz";
            //}
            //if (IsMultipleOf3(num))
            //{
            //    return "Fizz";
            //}
            //if (IsMultipleOf5(num))
            //{
            //    return "Buzz";
            //}
            //return num.ToString();

            string fizzBuzzResult = "";
            if (IsMultipleOf3(num))
            {
                fizzBuzzResult = "Fizz";
            }
            if (IsMultipleOf5(num))
            {
                fizzBuzzResult += "Buzz";
            }
            if (fizzBuzzResult == "")
            {
                fizzBuzzResult = num.ToString();
            }
            return fizzBuzzResult;
        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        private bool IsMultipleOf5(int numberTocheck)
        {
            return numberTocheck % 5 == 0;
        }

    }
}
