using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Input;
using SeleniumSharp.Tests.Base;
using SeleniumSharp.Tests.Controls;
using SeleniumSharp.Tests.Pages;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.ControlsTests.TextBox
{
    [TestFixture]
    public class TextBoxTests :  BaseTest
    {

        private TextBoxPage textBoxPage;
        
        [SetUp]
        public void SetupTest()
        {
            /*
            If data population is required, we can add it here. 
            
            My personal preference is having test classes be responsible for data creation
            and data deletion.
            
            Using a "golden" datasource is another route to take, but I have tried both and prefer 
            data creation and deletionwithin the test class.
            */
            TestContext.WriteLine("setup for textbox");
            textBoxPage = new TextBoxPage();
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/text-box.php");   
        }
        
        [Test]
        public void AddressCorrectlyDisplayed()
        {
            // with wrapper
            textBoxPage.address.TypeToId("123 Testing Avenue 60443").TypeToId(Keys.Tab);
            
            // selenium based code
            //driver.FindElement(By.Id("fullname")).SendKeys("Test");
            //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);
            
            Assert.That(textBoxPage.address.GetWebElement().GetDomProperty("value"), Is.EqualTo("123 Testing Avenue 60443"));
        }
        
        [Test]
        public void EmailCorrectlyDisplayed()
        {
            // with wrapper
            textBoxPage.email.TypeToId("testing@gmail.com").TypeToId(Keys.Tab);
            
            // selenium based code
            //driver.FindElement(By.Id("fullname")).SendKeys("Test");
            //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

            Assert.That(textBoxPage.email.GetWebElement().GetDomProperty("value"), Is.EqualTo("testing@gmail.com"));
        }

        [Test]
        public void FullnameCorrectlyDisplayed()
        {
            // with wrapper
            textBoxPage.fullName.TypeToId("Testing").TypeToId(Keys.Tab);
            
            // selenium based code
            //driver.FindElement(By.Id("fullname")).SendKeys("Test");
            //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

            Assert.That(textBoxPage.fullName.GetWebElement().GetDomProperty("value"), Is.EqualTo("Testing"));
        }

        [Test]
        public void FillOutPageAndHitSubmit()
        {
            textBoxPage.FillOutPage("Testing", "testing@gmail.com", "123 Testing Avenue 60443", "Password123");

            textBoxPage.submit.Click();
        }
        
        [Test]
        public void PasswordCorrectlyDisplayed()
        {
            // with wrapper
            textBoxPage.password.TypeToId("Password123").TypeToId(Keys.Tab);
            
            // selenium based code
            //driver.FindElement(By.Id("fullname")).SendKeys("Test");
            //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

            Assert.That(textBoxPage.password.GetWebElement().GetDomProperty("value"), Is.EqualTo("Password123"));
        }
    }   
}