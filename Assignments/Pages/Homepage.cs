using Assignments.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Assignments.Pages
{
    public class Homepages
    {

        public Homepages()
        {
            PageFactory.InitElements(PropertyCollections.driver, this);
        }

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement SignInButton {get; set;} 
        
        [FindsBy(How = How.CssSelector, Using = "[id='twotabsearchtextbox']")]
        public IWebElement SearchField {get; set;}
        
        [FindsBy(How = How.CssSelector, Using = "[aria-label='Search']")]
        public IWebElement Search {get; set;} 
    }
}
