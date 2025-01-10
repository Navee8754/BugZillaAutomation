using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]

        public void TextBox() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.Clear();
            //ele.SendKeys(ObjectRepository.Config.GetUsername());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));
            //ele.SendKeys(ObjectRepository.Config.GetPassword());


            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());

        }

    }
}
