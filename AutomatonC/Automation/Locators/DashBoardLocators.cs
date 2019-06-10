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
    class DashBoardLocators : PageObjectBase
    {
        public DashBoardLocators(IWebDriver Driver) : base(Driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "[href='/admin/logout/']")]
        protected IWebElement LogOutElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href='/admin/logout/']")]
        protected IWebElement ChangePasswordElement { get; set; }
    }
}
