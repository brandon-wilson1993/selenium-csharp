using NUnit.Framework;
using SeleniumSharp.Tests.Base;
using SeleniumSharp.Tests.Controls.List.Sortable;
using SeleniumSharp.Tests.Pages;

namespace SeleniumSharp.Tests.ControlsTests.List
{
    [TestFixture]
    public class SortableListTests : BaseTest
    {
        private SortableListPage sortableListPage;
        
        [SetUp]
        public void Setup()
        {
            sortableListPage = new SortableListPage(); 
            NavigateTo("sortable.php");
        }

        [Test]
        public void VerifyListOrder()
        {
            List<String> stuff = sortableListPage.sortableList.GetHeaders();
            
            
        }
    }   
}