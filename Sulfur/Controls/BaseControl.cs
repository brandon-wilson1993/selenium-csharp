using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Input;
using Sulfur.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulfur.Controls
{
    public class BaseControl
    {

        private String id;

        public BaseControl(String id) 
        {
            this.id = id;
        }

        public BaseControl TypeToId(String message)
        {
            IWebElement element = Driver.Driver.GetInstance().FindElement(By.Id(id));

            if (element == null)
            {
                throw new Exception($"{id} could not be found");
            }

            element.SendKeys(message);

            return this;
        }

        public IWebElement GetWebElement()
        {
            return Driver.Driver.GetInstance().FindElement(By.Id(id));
        }
    }
}
