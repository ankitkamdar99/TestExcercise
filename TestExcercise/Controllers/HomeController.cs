using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestExcercise.Models;
using TestExcercise.Utility;

namespace TestExcercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new NumberToWordModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult CalculateNumberToWords(NumberToWordModel model)
        {
            if (ModelState.IsValid)
            {
                var number = Convert.ToDouble(model.Number).ToString();
                var isNegative = "";
                var word = "";
                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    word = "The number in currency is Zero";
                }
                else
                {
                    word = string.Format("The number in currency format is \n {0}", isNegative + Conversion.ConvertToWords(number));
                }
                model.Words = word;
                return View("~/Views/Home/Index.cshtml", model);
            }
            model.Words = "";
            return View("~/Views/Home/Index.cshtml", model);
        }

    }
}