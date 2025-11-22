
/*
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate Webdriver
            IWebDriver driver = new ChromeDriver();

            // adding an implicit wait of 20 secs
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // launch the application
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/radio-button.php");
            
            // identify a radio button then click on radio button	
            IWebElement r = driver.FindElement
                (By.Name("/html/body/main/div/div/div[2]/form/div[3]/input"));
            r.Click();
            
            // identify text after clicking radio button
            IWebElement txt = driver.FindElement(By.Id("check1"));
         
            // obtain text
            String text = txt.Text;
            Console.WriteLine("Text is: " + text);
            
            
            // quitting browser
            driver.Quit();
        }
    }
}*/