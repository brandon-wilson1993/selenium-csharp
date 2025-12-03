using NUnit.Framework;
using SeleniumSharp.Tests.Base;
using SeleniumSharp.Tests.Controls.List.Sortable;
using SeleniumSharp.Tests.Pages;

namespace SeleniumSharp.Tests.ControlsTests.List.Sortable
{
    [TestFixture]
    public class SortableListTests : BaseTest
    {
        private SortableListPage sortableListPage;
        
        [SetUp]
        public void Setup()
        {
            NavigateTo("sortable.php");
            sortableListPage = new SortableListPage(); 
        }

        [Test]
        public void VerifyListOrder()
        {
            //List<string> stuff = sortableListPage.sortableList.GetListItemValue("Jacob", "First Name");
            sortableListPage.sortableList.GetListItemValue("Mark", "First Name");

        }
    }   
}