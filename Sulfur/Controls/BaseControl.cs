using OpenQA.Selenium;

namespace Sulfur.Controls
{
    public class BaseControl
    {

        private SelectorType selectorType;
        private String locatorIdentifier;

        public BaseControl(String locatorIdentifier, SelectorType selectorType)
        {
            this.selectorType = selectorType;
            this.locatorIdentifier = locatorIdentifier;
        }

        public BaseControl TypeToId(String message)
        {
            IWebElement element = FindElement();

            if (element == null)
            {
                throw new Exception($"{locatorIdentifier} could not be found");
            }

            element.SendKeys(message);

            return this;
        }

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

        public IWebElement GetWebElement()
        {
            return FindElement();
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
                    throw new Exception($"Unknown SelectorType  {selectorType}");
            }
        }
    }
}
