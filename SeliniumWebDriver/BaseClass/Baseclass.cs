using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Configuration;
using SeliniumWebDriver.CustomExpection;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeliniumWebDriver.BaseClass
{

    [Binding]
    public class Baseclass
    {  

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
           // options.AddExtension(@"C:\Users\goldh\AppData\Roaming\Postman");
            return options;
        }
        private static ChromeDriver GetChromeDriver()
        { 
        
       ChromeDriver driver = new ChromeDriver(GetChromeOptions());
        return driver;

        }
        private static EdgeDriver GetEdgeDriver()
        {

            EdgeDriver driver = new EdgeDriver();
            return driver;

        }
        private static FirefoxDriver GetFirefoxDriver()
        {
            FirefoxDriver driver = new FirefoxDriver();
            return driver;
        }
       
        [BeforeTestRun] 
        public static void IntitWebDriver(TestContext TC)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser()) 
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;


                case BrowserType.Edge:
                    ObjectRepository.Driver = GetEdgeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                    
                default:
                    throw new NoSuitableDriverFound("Driver Not Found :" + ObjectRepository.Config.GetBrowser().ToString());
            }
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            BrowserHelper.BrowserMaximize();
        }

        [AfterTestRun]

        public static void Teardown()
        { 
        if(ObjectRepository.Driver != null) 
            {
            
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            
            }
           
        }
    }
}
