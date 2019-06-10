using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatonC.Automation.BotStyleTest
{
    class BotStyle
    {
        public void SendKeys(IWebElement Element, String Text)
        {
            Element.Clear();
            Element.SendKeys(Text);
        }
    }
}
