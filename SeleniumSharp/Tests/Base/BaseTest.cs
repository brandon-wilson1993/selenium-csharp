using NUnit.Framework;
using OpenQA.Selenium;
using Sulfur.Driver;

namespace SeleniumSharp.Tests.Base
{
    public class BaseTest
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            TestContext.WriteLine("OneTimeSetup BaseTest");

            // login and save login state here to reuse across all tests
        }

        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine("Setup BaseTest");

            // go to base page, can also rely on the navigation within the tests instead of wasting time 
            // going back to the same page each time
            driver = Driver.GetInstance();
            // driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/text-box.php");
        }

        protected void NavigateTo(String pageName)
        {
            driver.Navigate().GoToUrl($"https://www.tutorialspoint.com/selenium/practice/{pageName}");
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.WriteLine("TearDown BaseTest");
            driver.Manage().Cookies.DeleteAllCookies(); // clean up any cookies
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.WriteLine("OneTimeTearDown BaseTest");
            Driver.Quit();
        }
    }   
}