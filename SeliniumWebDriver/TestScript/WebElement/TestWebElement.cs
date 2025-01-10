using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        
       
        [TestMethod]
        public void GetElement() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
              IReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine("Size : {0}", col.Count);
                Console.WriteLine("Size : {0}", col.ElementAt(0));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
           
        }
    }
}
