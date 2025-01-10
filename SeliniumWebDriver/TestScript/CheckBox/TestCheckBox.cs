using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]

        public void CheckBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_restrictlogin"));
            //ele.Click();
            Console.WriteLine(CheckBoxhelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
            CheckBoxhelper.CheckCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxhelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
            CheckBoxhelper.CheckCheckBox(By.Id("Bugzilla_restrictlogin"));


        }
    }
}
