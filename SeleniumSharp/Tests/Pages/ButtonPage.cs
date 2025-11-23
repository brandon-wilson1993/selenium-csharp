using SeleniumSharp.Tests.Controls;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.Pages
{
    public class ButtonPage
    {
        public Button clickMeButton;

        public ButtonPage()
        {
            clickMeButton = new Button(".btn.btn-primary", SelectorType.CssSelector);
        }
    }   
}