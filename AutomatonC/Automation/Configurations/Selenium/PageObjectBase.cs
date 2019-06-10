using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomatonC.Automation.BotStyleTest;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomatonC.Automation.Configurations.Selenium
{
    class PageObjectBase
    {
        private IWebDriver driver;
        public IWebDriver Driver
        {
            get {
                return this.driver;
            }
            set {
                this.driver = value;
            }
        }

        private BotStyle bot;
        public BotStyle Bot
        {
            get
            {
                return bot;
            }
            set
            {
                this.bot = value;
            }
        }

        public PageObjectBase(IWebDriver Driver)
        {
            this.Driver = Driver;
            this.Bot = new BotStyle();
            PageFactory.InitElements(Driver, this);
        }
    }
}
