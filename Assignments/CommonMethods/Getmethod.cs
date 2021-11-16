using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.CommonMethods
{
    class Getmethod
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextDropDown(IWebElement element, PropertyType elementtype)
        {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
    }
}
