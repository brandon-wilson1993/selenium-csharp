using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSharp.Tests.Base;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.ControlsTests.Button
{
    [TestFixture]
    public class ButtonTests : BaseTest
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

            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/buttons.php");
        }

        [Test]
        public void ClickMeButton()
        {
            Controls.Button clickMeButton = new Controls.Button(".btn.btn-primary", SelectorType.CssSelector);
            clickMeButton.Click();

            Assert.That(driver.FindElement(By.Id("welcomeDiv")).Text, Is.EqualTo("You have done a dynamic click"));
        }
    }   
}