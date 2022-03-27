using System;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb_2.Models
{
    public class FizzBuzz : validation
    {
        [Display(Name = "Twój szczęśliwy numerek")]

        [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        [validation]
        public int? Number { get; set; }

    }

}