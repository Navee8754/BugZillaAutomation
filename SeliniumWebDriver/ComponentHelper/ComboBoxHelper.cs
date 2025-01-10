using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(Generichelper.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectElement(By locator, string visibletest)
        {
            select= new SelectElement(Generichelper.GetElement(locator));
            select.SelectByText(visibletest);
        }

        public static IList<string> GetAllItem(By locator) 
        {
            select = new SelectElement(Generichelper.GetElement(locator));
            return select.Options.Select((x)  => x.Text).ToList();
        }
    }
}
