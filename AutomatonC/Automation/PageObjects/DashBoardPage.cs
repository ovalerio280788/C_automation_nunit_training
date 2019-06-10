using AutomatonC.Automation.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatonC.Automation.PageObjects
{
    class DashBoardPage : DashBoardLocators
    {
        public DashBoardPage(IWebDriver Driver) : base(Driver)
        {
        }

        public bool IsChangePasswordDisplayed()
        {
            return this.ChangePasswordElement.Displayed;
        }

        public bool IsLogOutDisplayed()
        {
            return this.ChangePasswordElement.Displayed;
        }
    }
}
