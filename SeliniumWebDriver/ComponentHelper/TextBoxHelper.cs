using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;
        public static void TypeInTextBox(By locator, string Text)
        {
            element = Generichelper.GetElement(locator);
            element.SendKeys(Text);
        }
        public static void ClearTextBox(By locator)
        {
            element = Generichelper.GetElement(locator);
            element.Clear();
        }
    }
}
