using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement element;

        public static void ClickRadioButton(By locator)
        {
            element = Generichelper.GetElement(locator);
            element.Click();

        }

        public static bool IsRadioButtonSelected(By locator) 
        {
            element = Generichelper.GetElement(locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)

                return false;

            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
