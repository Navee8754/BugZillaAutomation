﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.DefaultWait
{
    [TestClass]
    public class HandleDefaultWait
    {
        [TestMethod]
        public void TestDefaultWait()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));

            Generichelper.WaitForWebElement(By.Id("bug_severity"),TimeSpan.FromSeconds(20));
           IWebElement ele = Generichelper.WaitForWebElementInPage(By.Id("bug_severity"), TimeSpan.FromSeconds(50));


            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            //DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepository.Driver.FindElement(By.Id("bug_severity")));
            //wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            //wait.Timeout = TimeSpan.FromSeconds(50);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Console.WriteLine("After Wait {0}",wait.Until(changeofvalue()));
        }

        //private Func<IWebElement, string> changeofvalue()
        //{
        //    return ((x) =>
        //    {
        //        SelectElement select = new SelectElement(x);
        //        if (select.SelectedOption.Text.Equals("major"))
        //            return select.SelectedOption.Text;
        //        return null;
        //    });
        //}
    }
}
