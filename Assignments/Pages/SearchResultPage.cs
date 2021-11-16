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
    class SearchResultPage
    {
        public SearchResultPage()
        {
            PageFactory.InitElements(PropertyCollections.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[class='a-size-medium a-color-base a-text-normal']")]
        public IWebElement SearchedResults { get; set; } 
        
        [FindsBy(How = How.CssSelector, Using = "[alt*='Apple iPhone']")]
        public IWebElement Iphone { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "[id='add-to-cart-button']")]
        public IWebElement AddToCart { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "[id='hlb-subcart']")]
        public IWebElement CheckAddedToCart { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#nav-cart-count-container")]
        public IWebElement MyCart { get; set; }




    }
}
