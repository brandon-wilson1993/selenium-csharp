using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace Sulfur.Controls
{
 public class BaseControl
{
    private readonly string locatorIdentifier;

    private readonly SelectorType selectorType;

    public BaseControl(string locatorIdentifier, SelectorType selectorType)
    {
        this.selectorType = selectorType;
        this.locatorIdentifier = locatorIdentifier;
    }

    // ======= CONTROL ACTIONS ======= //

    /// <summary>
    ///     Clicks on the control
    /// </summary>
    /// <returns>BaseControl Object to allow chaining</returns>
    /// <exception cref="Exception">if element can not be found on screen</exception>
    public BaseControl Click()
    {
        IWebElement element = FindElement();

        if (element == null)
        {
            throw new Exception($"{locatorIdentifier} could not be found");
        }

        element.Click();

        return this;
    }

    /// <summary>
    ///     Type to the control
    /// </summary>
    /// <param name="message">message to type into control</param>
    /// <returns>BaseControl object to allow chaining</returns>
    /// <exception cref="Exception">if element can not be found on screen</exception>
    public BaseControl Type(string message)
    {
        IWebElement element = FindElement();

        if (element == null)
        {
            throw new Exception($"{locatorIdentifier} could not be found");
        }

        element.SendKeys(message);

        return this;
    }

    // ======= GET WEB ELEMENT DETAILS ========= //

    /// <summary>
    ///     Get the IWebElement object of the control
    /// </summary>
    /// <returns>IWebElement of the control</returns>
    public IWebElement GetWebElement()
    {
        return FindElement();
    }

    /// <summary>
    ///     Get the value of a Dom Property, null is returned if value is not found or set
    /// </summary>
    /// <param name="property">Value of Property to get</param>
    /// <param name="expectBlank">Flag to throw exception if property should not be blank, Defaults to false</param>
    /// <returns>Dom Property value</returns>
    /// <exception cref="Exception">Throws exception if result is null and expectBlank is false</exception>
    public string GetDomProperty(string property, bool expectBlank = false)
    {
        String result = FindElement().GetDomProperty(property);

        if (result == null && !expectBlank)
        {
            throw new Exception($"Value of {property} was empty");
        }

        return result;
    }

    private IWebElement FindElement()
    {
        switch (selectorType)
        {
            case SelectorType.Id:
                return Driver.Driver.GetInstance().FindElement(By.Id(locatorIdentifier));
            case SelectorType.CssSelector:
                return Driver.Driver.GetInstance().FindElement(By.CssSelector(locatorIdentifier));
            default:
                throw new Exception($"Unknown SelectorType {selectorType}");
        }
    }
}   
}