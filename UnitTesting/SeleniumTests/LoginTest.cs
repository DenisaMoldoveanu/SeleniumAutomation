using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.SeleniumTests
{
    [TestClass]
    public class LoginTest
    {

        IWebDriver driver;

        [TestMethod]
        public void NavigateToIbmSite()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.ibm.com/ro-en");

            IWebElement frameElement = driver.FindElement(By.XPath("//iframe[contains(@id,'pop-frame')]"));
            driver.SwitchTo().Frame(frameElement);
            driver.FindElement(By.ClassName("call")).Click();

        }

        [TestMethod]
        public void AcceptSiteCookies()
        {
           
        }
    }
}
