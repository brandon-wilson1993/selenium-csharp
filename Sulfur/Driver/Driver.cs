using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sulfur.Driver
{
    public sealed class Driver
    {
        private static Driver driver = new();
        private readonly IWebDriver webDriver;

        private Driver()
        {
            Debug.WriteLine("New Driver created");

            // this should be easier to change within the test project
            ChromeOptions options = new ChromeOptions();

            String noheadless = Environment.GetEnvironmentVariable("NO_HEADLESS");

            // run headless is env var is not set, default to headless
            if (noheadless == null || noheadless.ToLower() == "false")
            {
                options.AddArgument("--headless=new");
            }

            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--no-sandbox");

            webDriver = new ChromeDriver(options);
        }

        public static IWebDriver GetInstance()
        {
            if (driver == null) driver = new Driver();

            return driver.webDriver;
        }

        public static void Quit()
        {
            driver.webDriver.Quit();
            driver = null;
        }
    }   
}