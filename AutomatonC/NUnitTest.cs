using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomatonC
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test01()
        {
            driver.Url = "http://127.0.0.1:9000/admin/";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

    }
}
