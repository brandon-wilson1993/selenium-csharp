using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSharp.Tests.Base;
using SeleniumSharp.Tests.Controls;
using Sulfur.Assertions;

namespace SeleniumSharp.Tests.ControlsTests.TextBoxTests
{
    [TestFixture]
    public class TextBoxTests :  BaseTest
    {

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
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/text-box.php");   
        }

        [Test]
        public void FullnameCorrectlyDisplayed()
        {
            // with wrapper
            TextBox textBox = new TextBox("fullname");
            textBox.TypeToId("Test").TypeToId(Keys.Tab);

            //// old code
            //driver.FindElement(By.Id("fullname")).SendKeys("Test");
            //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

            // with wrapper
            AssertionsById.AssertIsEqualTo(textBox, "value", "Test");

            // old code
            //Assert.That(driver.FindElement(By.Id("fullname")).GetDomProperty("value"), Is.EqualTo("Tes"));
        }
    }   
}