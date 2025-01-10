using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using SeliniumWebDriver.Configuration;
using SeliniumWebDriver.Interfaces;
using System;

namespace SeliniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        public ChromeDriver ChromeDriver { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
          IConfig config = new AppConfigReader();

            Console.WriteLine("Test");
        }
    }
}
