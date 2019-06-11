using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatonC.Automation.BotStyleTest;
using AutomatonC.Automation.Locators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatonC.Automation.PageObjects
{
    class LoginPage : LoginLocators
    {
        public LoginPage(IWebDriver Driver): base(Driver)
        {
        }

        public void FillUserName(String UserName)
        {
            this.Bot.SendKeys(this.UserNameElement, UserName);
        }

        public void FillPassword(String Password)
        {
            this.Bot.SendKeys(this.PasswordElement, Password);
        }

        public DashBoardPage Submit()
        {
            this.Driver.FindElement(this.SubmitElement).Submit();
            return new DashBoardPage(this.Driver);
        }
    }
}
