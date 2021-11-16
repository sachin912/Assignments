using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.CommonMethods
{
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        CssName,
        LinkText,
    }

    public class PropertyCollections
    {
        public static IWebDriver driver { get; set; } 
        public static WebDriverWait wait { get; set; } 
    }
}
