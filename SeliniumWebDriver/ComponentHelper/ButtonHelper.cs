using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class ButtonHelper
    {
        private static IWebElement element;

        public static void  ClickButton(By locator)
        {
            element = Generichelper.GetElement(locator);
            element.Click();
        }
    }
}
