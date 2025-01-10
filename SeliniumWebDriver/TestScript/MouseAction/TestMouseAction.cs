using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.MouseAction
{
    [TestClass]
    public class TestMouseAction
    {
        [TestMethod]
        public void TestContextClick()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            act.ContextClick(ele)
               .Build()
               .Perform();

            Thread.Sleep(5000);
        }
        [TestMethod]
        public void TestDragandDrop()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            IWebElement tar = ObjectRepository.Driver.FindElement(By.Id("droptarget"));
            ButtonHelper.ClickButton(By.Id("onetrust-accept-btn-handler"));
            act.DragAndDrop(src, tar)
               .Build()
               .Perform();

            Thread.Sleep(5000);
        }
        [TestMethod]
        public void TestClickNHold()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[12]"));
            IWebElement tar = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[1]"));
            ButtonHelper.ClickButton(By.Id("onetrust-accept-btn-handler"));
            act.ClickAndHold(ele)
                .MoveToElement(tar)
                .Release()
                .Build() .Perform();
        }
        [TestMethod]
        public void Testkeyboard()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Actions act = new Actions(ObjectRepository.Driver);

            //ctrl+shift+a
            act.KeyDown(Keys.LeftControl)
                 .KeyDown(Keys.LeftShift)
                 .SendKeys("a")
                 .KeyUp(Keys.LeftShift)
                 .KeyUp(Keys.LeftControl)
                 .Build()
                 .Perform();
                 
        }
    }
}
