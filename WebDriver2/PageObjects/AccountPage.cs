using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver2.PageObjects
{
    public class AccountPage
    {
        //Finds the (logout) element button using the 'By' strategy searching for the "account_logout" HTML Id.
        [FindsBy(How = How.Id, Using = "account_logout")]
        public IWebElement Logout { get; set; }
    }
}
