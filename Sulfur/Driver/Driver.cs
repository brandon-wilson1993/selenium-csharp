using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

namespace Sulfur.Driver
{
    public sealed class Driver
    {
        private IWebDriver webDriver;
        private static Driver driver = new Driver();

        public static IWebDriver GetInstance()
        {
            if(driver == null)
            {
                driver = new Driver();
            }

            return driver.webDriver;
        }

        private Driver()
        {
            Debug.WriteLine("New Driver created");

            // this should be easier to change within the test project
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless=new");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--no-sandbox");

            webDriver = new ChromeDriver(options);
        }

        public static void Quit()
        {
            driver.webDriver.Quit();
            driver = null;
        }
    }
}
