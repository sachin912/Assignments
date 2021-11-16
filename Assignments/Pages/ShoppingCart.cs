using Assignments.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Pages
{
    class ShoppingCart
    {
        public ShoppingCart()
        {
            PageFactory.InitElements(PropertyCollections.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[value='Delete']")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.ClassName, Using = ".a-spacing-mini.a-spacing-top-base")]
        public IWebElement CartIsEmpty { get; set; }

    }
}
