using NUnit.Framework;
using SeleniumSharp.Tests.Controls.List.Sortable;
using Sulfur.Controls;

namespace SeleniumSharp.Tests.Pages;

public class SortableListPage
{
    public SortableList sortableList;

    public SortableListPage()
    {
        sortableList = new SortableList("nav-home", SelectorType.Id);
    }
}