using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver2.PageObjects
{
    public class HomePage
    {

        /* Finds the account button element in the page using the 'By' strategy. FindBy can accept, 
         * TagName, PartialLinkText, Name, LinkText, Id, Css, ClassName, and XPath as attributes.  
         * 
         * Below we create a PageObject finding it by using its HTML Id, "account".
         */
        [FindsBy(How = How.Id, Using = "account")]
        public IWebElement MyAccount { get; set; }
    }
}
