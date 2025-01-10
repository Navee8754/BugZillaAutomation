using SeliniumWebDriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeliniumWebDriver.Settings;
using OpenQA.Selenium;
using SeliniumWebDriver.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeliniumWebDriver.StepDefinition
{
    [Binding]
    public class TestFeature
    {
        private HomePage hPage;
        private LoginPage lPage;
        private BugDetailPage bPage;

        #region Given
        [Given(@"User at the login page")]
        public void GivenUserAtTheLoginPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
        [Given(@"File a bug should visiable")]
        public void GivenFileABugShouldVisiable()
        {
            Assert.IsTrue(Generichelper.IsElementPresent(By.Id("enter_bug")));
        }
        #endregion

        #region When
        [When(@"I click on file a bug link")]
        public void WhenClickOnFileABugLink()
        {
            hPage = new HomePage(ObjectRepository.Driver);
            lPage= hPage.NavigateToLogin();
        }

        [When(@"I provide username and password and click on login button")]
        public void WhenIProvideUsernameAndPasswordAndClickOnLoginButton()
        {
            bPage = lPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            
        }

        [When(@"I provide severity, hardware, platform and summary")]
        public void WhenIProvideSeverityHardwarePlatformAndSummary()
        {
            bPage.SelectFromComboBox("major", "Macintosh", "Mac OS");
            bPage.TypeIn("Automation script is runnig fine");
        }

        [When(@"Click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            bPage.ClickSubmit();
        }

        [When(@"User clicked on lodout button")]
        public void WhenUserClickedOnLodoutButton()
        {
            bPage.ClickLogout();
        }

        #endregion

        #region Then

        [Then(@"User should be at login page")]
        public void ThenUserAbEToSeeTheLoginPage()
        {
            Assert.AreEqual("Bugzilla – Log in to Bugzilla", lPage.GetPageTitle());
        }

        [Then(@"User should be at Enter bug page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
            AssertHelper.AreEqual("Bugzilla – Enter Bug: TestProduct", bPage.GetPageTitle());
        }

        [Then(@"Bug should be cretaed")]
        public void ThenBugShouldBeCretaed()
        {
            Assert.IsTrue(Generichelper.IsElementPresent(By.Id("title")));
        }

        [Then(@"User should be logged out and should be at home page")]
        public void ThenUserShouldBeLoggedOutAndShouldBeAtHomePage()
        {
            AssertHelper.IsTrue(Generichelper.IsElementPresent(By.Id("welcome")));
        }


        #endregion

    }
}
