using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.Popup
{
    [TestClass]
    public class TestPopups
    {
        private IWebDriver driver;
        [TestMethod]
        public void TestAlert()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("//div[@id=\"main\"]/div[4]/a"));
            BrowserHelper.SwitchToWindow(1);
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text() = 'Try it']"));
            var text = JavaScriptpopupHelper.GetPopupText();
            JavaScriptpopupHelper.ClickPopupOk();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//*[@id=('textareaCode')]")); 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ObjectRepository.Driver.ExecuteJavaScript("arguments[0].style.display = 'block';", element);
            TextBoxHelper.ClearTextBox(By.XPath("//*[@id=('textareaCode')]"));
            
        }
        [TestMethod]
        public void TestConfirm()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text ()= 'Try it']"));
            var text = JavaScriptpopupHelper.GetPopupText();
            JavaScriptpopupHelper.ClickPopupOk();
            ButtonHelper.ClickButton(By.XPath("//button[text ()= 'Try it']"));
            JavaScriptpopupHelper.ClickOnCancle();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            ButtonHelper.ClickButton(By.Id("runbtn"));
        }

        [TestMethod]
        public void TestPrompt()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text ()= 'Try it']"));
            var text = JavaScriptpopupHelper.GetPopupText();
            JavaScriptpopupHelper.Sendkeys(text);
            JavaScriptpopupHelper.ClickPopupOk();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            IWebElement element = ObjectRepository.Driver.FindElement(By.XPath("//*[@id=('textareaCode')]"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ObjectRepository.Driver.ExecuteJavaScript("arguments[0].style.display = 'block';", element);
            TextBoxHelper.ClearTextBox(By.XPath("//*[@id=('textareaCode')]"));
            TextBoxHelper.TypeInTextBox(By.XPath("//*[@id=('textareaCode')]"), text);
        }
    }
}
