using NUnit.Framework;
using OpenQA.Selenium;
using Sulfur.Controls;
using Sulfur.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulfur.Assertions
{
    public class AssertionsById
    {
        public static void AssertIsEqualTo(IWebElement webElement, String domProperty, String expectedValue)
        {
            Assert.That(webElement.GetDomProperty(domProperty), Is.EqualTo(expectedValue));
        }

        public static void AssertIsEqualTo(BaseControl baseControl, String domProperty, String expectedValue)
        {
            Assert.That(baseControl.GetWebElement().GetDomProperty(domProperty), Is.EqualTo(expectedValue));
        }
    }
}
