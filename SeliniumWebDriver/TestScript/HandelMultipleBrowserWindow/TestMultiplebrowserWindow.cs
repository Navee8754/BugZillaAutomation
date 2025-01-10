using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.HandelMultipleBrowserWindow
{
    [TestClass]
    public class TestMultiplebrowserWindow
    {
        [TestMethod]
        public void TestMultilpleBrowserWindow() 
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/java/default.asp");
            ButtonHelper.ClickButton(By.XPath("//div[@class='w3-example']/p/a"));
            BrowserHelper.SwitchToWindow(1);
            BrowserHelper.SwitchToParent();
            
            //ReadOnlyCollection<string> windows= ObjectRepository.Driver.WindowHandles;
            //ObjectRepository.Driver.SwitchTo().Window(windows[1]);
            //ButtonHelper.ClickButton(By.XPath("//div[@class='trytopnav']/div/button"));
        }
    }
}
