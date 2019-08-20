using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestExcercise.Models
{
    public class NumberToWordModel
    {
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "Enter valid currency value.")]
        public string Number { get; set; }
        public string Words { get; set; }
    }
}