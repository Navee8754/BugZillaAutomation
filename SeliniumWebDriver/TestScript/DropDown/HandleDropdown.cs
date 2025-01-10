using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.DropDown
{
    [TestClass]
    public class HandleDropdown
    {
        [TestMethod]
        public void SelectDropDown() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("bug_severity"));
            ComboBoxHelper.SelectElement(By.Id("bug_severity"), "major");
            ComboBoxHelper.SelectElement(By.Id("bug_severity"), 3);
            foreach (string str in ComboBoxHelper.GetAllItem(By.Id("bug_severity"))) 
            {
                Console.WriteLine("Text : {0}",str);
            }
        }
    }
}
