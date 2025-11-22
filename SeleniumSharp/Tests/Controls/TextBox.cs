using Sulfur.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSharp.Tests.Controls
{
    public class TextBox : BaseControl
    {
        private String id;

        public TextBox(String id, SelectorType selectorType) : base(id, selectorType) { }
    }
}
