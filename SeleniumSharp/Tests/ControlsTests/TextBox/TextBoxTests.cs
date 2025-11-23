using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSharp.Tests.Base;
using SeleniumSharp.Tests.Pages;

namespace SeleniumSharp.Tests.ControlsTests.TextBox
{
 [TestFixture]
public class TextBoxTests : BaseTest
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
        textBoxPage = new TextBoxPage();
        
        NavigateTo("text-box.php");
    }

    [Test]
    public void AddressCorrectlyDisplayed()
    {
        String address = "123 Testing Avenue 60443";

        // with wrapper
        textBoxPage.address.Type(address).Type(Keys.Tab);

        // selenium based code
        //driver.FindElement(By.Id("fullname")).SendKeys("Test");
        //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

        Assert.That(textBoxPage.address.GetDomProperty("value"), Is.EqualTo(address));
    }

    [Test]
    public void EmailCorrectlyDisplayed()
    {
        String email = "testing@gmail.com";

        // with wrapper
        textBoxPage.email.Type(email).Type(Keys.Tab);

        // selenium based code
        //driver.FindElement(By.Id("fullname")).SendKeys("Test");
        //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

        Assert.That(textBoxPage.email.GetDomProperty("value"), Is.EqualTo(email));
    }

    [Test]
    public void FullnameCorrectlyDisplayed()
    {
        String fullname = "Testing";

        // with wrapper
        textBoxPage.fullName.Type(fullname).Type(Keys.Tab);

        // selenium based code
        //driver.FindElement(By.Id("fullname")).SendKeys("Test");
        //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

        Assert.That(textBoxPage.fullName.GetDomProperty("value"), Is.EqualTo(fullname));
    }

    [Test]
    public void FillOutPageAndHitSubmit()
    {
        textBoxPage.FillOutPage("Testing", "testing@gmail.com", "123 Testing Avenue 60443", "Password123");

        textBoxPage.submit.Click();

        // TODO: look into explicit waits 

        Assert.That(textBoxPage.fullName.GetDomProperty("value"), Is.Null.Or.Empty);
        Assert.That(textBoxPage.email.GetDomProperty("value"), Is.Null.Or.Empty);
        Assert.That(textBoxPage.address.GetDomProperty("value"), Is.Null.Or.Empty);
        Assert.That(textBoxPage.password.GetDomProperty("value"), Is.Null.Or.Empty);
    }

    [Test]
    public void PasswordCorrectlyDisplayed()
    {
        String password = "Password123";

        // with wrapper
        textBoxPage.password.Type(password).Type(Keys.Tab);

        // selenium based code
        //driver.FindElement(By.Id("fullname")).SendKeys("Test");
        //driver.FindElement(By.Id("fullname")).SendKeys(Keys.Tab);

        Assert.That(textBoxPage.password.GetDomProperty("value"), Is.EqualTo(password));
    }
}   
}