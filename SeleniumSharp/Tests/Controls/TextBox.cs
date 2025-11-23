using Sulfur.Controls;

namespace SeleniumSharp.Tests.Controls
{
    public class TextBox : BaseControl
    {
        private string id;

        public TextBox(string id, SelectorType selectorType) : base(id, selectorType)
        {
        }
    }   
}