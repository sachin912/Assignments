using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.CommonMethods
{
    class Setmethod
    {
        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click
        public static void Click(IWebElement element)
        {
            element.Click();
        }
        
        //DropDown
        public static void DropDown(IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }

    }
}
