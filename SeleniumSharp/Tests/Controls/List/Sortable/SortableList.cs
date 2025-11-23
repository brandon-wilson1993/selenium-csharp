using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.Controls.List.Sortable
{
    public class SortableList
    {
        private BaseControl parentElement;
        private List<String> headers;
        
        public SortableList(String locationIdentifier, SelectorType selectorType)
        {
            headers = new List<string>();
            parentElement = new BaseControl(locationIdentifier, selectorType);
        }

        public List<String> GetHeaders()
        {
            List<IWebElement> headerElements = parentElement.GetWebElement().FindElements(By.CssSelector("table thead th")).ToList();

            for (int idx = 0; idx < headerElements.Count; idx++)
            {
                headers.Add(headerElements[idx].Text);
                TestContext.WriteLine($"header {idx}: {headerElements[idx].Text}");
            }
            
            return headers;
        }
    }
}