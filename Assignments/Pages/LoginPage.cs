using Assignments.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PropertyCollections.driver, this);
        }

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement SignInSubmitButton { get; set; }
    }
}
