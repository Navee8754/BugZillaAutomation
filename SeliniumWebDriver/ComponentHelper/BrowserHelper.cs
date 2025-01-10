using OpenQA.Selenium;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void Back()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward(); 
        }
        public static void Refersh()
        {
            ObjectRepository.Driver.Navigate().Refresh(); 
        }
        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" +  index);
            }

            Thread.Sleep(1000);
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximize();
        }
        public static void SwitchToParent()
        {
            var windowsids = ObjectRepository.Driver.WindowHandles;
            for (int i = 0; i > 0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowsids[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowsids[0]);
        }
        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));
        }
    }
}
