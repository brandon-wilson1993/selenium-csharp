using SeleniumSharp.Tests.Controls;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.Pages
{
    public class TextBoxPage
    {
        public TextBox address;
        public TextBox email;
        public TextBox fullName;
        public TextBox password;
        public Button submit;

        public TextBoxPage()
        {
            address = new TextBox("address", SelectorType.Id);
            email = new TextBox("email", SelectorType.Id);
            password = new TextBox("password", SelectorType.Id);
            fullName = new TextBox("fullname", SelectorType.Id);
            submit = new Button(".btn.btn-primary", SelectorType.CssSelector);
        }

        public void FillOutPage(string name, string email, string address, string password)
        {
            fullName.Type(name);
            this.email.Type(email);
            this.address.Type(address);
            this.password.Type(password);
        }
    }   
}