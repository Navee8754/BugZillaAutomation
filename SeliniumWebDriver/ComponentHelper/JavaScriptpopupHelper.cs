using OpenQA.Selenium;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class JavaScriptpopupHelper
    {
        public static bool IsPopupPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch(NoAlertPresentException)
            {
                return false;
            }
        }
        public static string GetPopupText()
        {
            if (!IsPopupPresent())
                return "";
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        }

        public static void ClickPopupOk()
        {
            if (!IsPopupPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Accept();
        }
        public static void ClickOnCancle()
        {
            if (!IsPopupPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
        }
        public static void Sendkeys(string text) 
        {
            if (!IsPopupPresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
