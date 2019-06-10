using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;

namespace AutomatonC.Automation.Configurations.Selenium
{
    class TestCaseBase : SeleniumBase
    {
        [SetUp]
        public void SetUp()
        {
            SetUpBase(ConfigurationManager.AppSettings["BROWSER"], ConfigurationManager.AppSettings["URL"]);
        }

        [TearDown]
        public void TearDown()
        {
            TearDownBase();
        }
    }
}
