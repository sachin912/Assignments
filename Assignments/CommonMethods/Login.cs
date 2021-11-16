using Assignments.Constants;
using Assignments.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.CommonMethods
{
     class Login
    {
        public static void ToHomepage()
        {
            PropertyCollections.driver = new ChromeDriver();
            PropertyCollections.driver.Navigate().GoToUrl("https://www.amazon.com/");
            PropertyCollections.wait = new WebDriverWait(PropertyCollections.driver, TimeSpan.FromSeconds(10));
            Homepages Homepage = new Homepages();
            Homepage.SignInButton.Click();
            LoginPage Loginpage = new LoginPage();
            PropertyCollections.wait.Until(verify => Loginpage.Email.Displayed);
            Loginpage.Email.SendKeys(CommonConstants.UserName);
            Loginpage.ContinueButton.Click();
            Loginpage.Password.SendKeys(CommonConstants.Password);
            Loginpage.SignInSubmitButton.Click();
            PropertyCollections.wait.Until(verify => Homepage.SignInButton.Displayed);
        }
    }
}
