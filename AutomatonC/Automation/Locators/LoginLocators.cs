using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatonC.Automation.Configurations.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatonC.Automation.Locators
{
    class LoginLocators : PageObjectBase
    {
        public LoginLocators(IWebDriver Driver) : base(Driver)
        {
        }

        [FindsBy(How = How.Id, Using = "id_username")]
        protected IWebElement UserNameElement { get; set; }

        [FindsBy(How = How.Id, Using = "id_password")]
        protected IWebElement PasswordElement { get; set; }

        protected By SubmitElement = By.XPath("[type='submit']");
    }
}
