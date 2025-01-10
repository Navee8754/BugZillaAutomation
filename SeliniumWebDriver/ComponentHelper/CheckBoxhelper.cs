using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class CheckBoxhelper
    {
        private static IWebElement element;

        public static void CheckCheckBox(By locator)
        {
            element = Generichelper.GetElement(locator);
            element.Click();
        }

        public static bool IsCheckBoxChecked(By Locator)
        {
            element = Generichelper.GetElement(Locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)

                return false;

            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
