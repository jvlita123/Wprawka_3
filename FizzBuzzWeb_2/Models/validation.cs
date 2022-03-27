using System;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb_2.Models
{
    public class validation : ValidationAttribute
    {

        public validation() { }
        public override bool IsValid(object? number)
        {

            if (Convert.ToInt32(number) % 3 == 0 && Convert.ToInt32(number) % 5 == 0)
            {
                ErrorMessage = "FizzBuzz";
                return true;
            }
            else if ((int)number % 5 == 0)
            {
                ErrorMessage = "Buzz";
                return true;
            }
            else if ((int)number % 3 == 0)
            {
                ErrorMessage = "Fizz";
                return true;
            }
            else
            {
                ErrorMessage = "Liczba nie spelnia warunkow zadania";
                return true;
            }

        }

    }
}


