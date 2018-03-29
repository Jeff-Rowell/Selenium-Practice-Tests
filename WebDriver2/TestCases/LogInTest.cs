using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using WebDriver2.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriver2.TestCases
{
    [TestFixture]
    public class LogInTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void TestLogIn()
        {
            _driver.Url = "http://www.store.demoqa.com";

            var homePage = new HomePage();
            //Initializes the elements of the homePage PageObject
            PageFactory.InitElements(_driver, homePage);
            homePage.MyAccount.Click(); //Clicks on the MyAccount button

            var loginPage = new LogInPage();
            //Initializes the elements of the loginPage PageObject
            PageFactory.InitElements(_driver, loginPage);
            //Note: Set up your own username and password at http://www.store.demoqa.com
            loginPage.UserName.SendKeys("dummyUserTest"); //Types the username in the text box
            loginPage.Password.SendKeys("$Olive%Pass$");  //Types the password in the other text box
            loginPage.Submit.Submit(); //Submits the login request, this is like clicking the 'submit' button

            //Wait 4 seconds for page to load, this freezes the current processing thread
            System.Threading.Thread.Sleep(4000);

            var accountPage = new AccountPage();
            PageFactory.InitElements(_driver, accountPage);
            accountPage.Logout.Click();
            //Wait 4 seconds to make sure logout is successful
            System.Threading.Thread.Sleep(4000);
            _driver.Quit();
        }
    }
}
