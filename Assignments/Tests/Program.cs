using Assignments.CommonMethods;
using Assignments.Constants;
using Assignments.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Assignments
{
    public class Program
    {

        static void Main(string [] args)
        {
        }
       
        [SetUp]
        public void Initilaise()
        {
            Login.ToHomepage();
        }

        [Test]
        public void AddToCart()
        {
            Homepages Homepage = new Homepages();
            Homepage.SearchField.SendKeys(ProductsConstant.Iphone);
            Homepage.Search.Click();
            SearchResultPage searchResult = new SearchResultPage();
            PropertyCollections.wait.Until(verify => searchResult.Iphone.Displayed);
            searchResult.Iphone.Click();
            PropertyCollections.wait.Until(verify => searchResult.AddToCart.Displayed);
            searchResult.AddToCart.Click();
            PropertyCollections.wait.Until(verify => searchResult.CheckAddedToCart.Displayed);
            Assert.IsTrue(searchResult.CheckAddedToCart.Displayed, searchResult.CheckAddedToCart.Displayed);
            test.
            searchResult.MyCart.Click();
        }

        [TearDown]
        public void cleanup()
        {
                ShoppingCart shoppingCartPage = new ShoppingCart();
                    shoppingCartPage.DeleteButton.Click();
                PropertyCollections.driver.Quit();
        }
    }
}
