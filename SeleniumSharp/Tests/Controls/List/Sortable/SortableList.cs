using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.Controls.List.Sortable
{
    public class SortableList
    {
        private BaseControl parentElement;
        private String parentIdentifier;
        private List<String> headers;
        
        public SortableList(String locationIdentifier, SelectorType selectorType)
        {
            parentElement = new BaseControl(locationIdentifier, selectorType);
            parentIdentifier = locationIdentifier;
            headers = GetHeaders();
        }

        public String GetListItemValue(String findByValue, String findByColumn)
        {
            int headerIndex = GetHeaderIndex(findByColumn);

            List<IWebElement> listOfElements = parentElement.GetWebElement().FindElements(By.CssSelector($" table tbody tr:nth-child({headerIndex + 1})")).ToList();

            for (int idx = 0; idx < listOfElements.Count; idx++)
            {
                TestContext.WriteLine($"header {idx}: {listOfElements[idx].Text}");
            }

            return "";
        }

        public List<String> GetHeaders()
        {
            List<String> list = new List<string>();
            ReadOnlyCollection<IWebElement> headerElements = parentElement.GetWebElement().FindElements(By.CssSelector(" table thead th"));

            for (int idx = 0; idx < headerElements.Count; idx++)
            {
                list.Add(headerElements[idx].Text);
                // TestContext.WriteLine($"header {idx}: {headerElements[idx].Text}");
            }
            
            return list;
        }

        private int GetHeaderIndex(String headerName)
        {
            int index = 0;

            for (int idx = 0; idx < headers.Count; idx++)
            {
                if (headers[idx].Equals(headerName))
                {
                    index = idx;
                    break;
                }
            }

            // if the index is the length of the list then the item was not found
            Assert.That(index, Is.Not.EqualTo(headers.Count));

            return index;
        }
    }
}