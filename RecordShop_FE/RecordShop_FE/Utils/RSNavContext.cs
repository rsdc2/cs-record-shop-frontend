
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecordShop;

public class RSNavContext
{
    NavigationManager _navigationManager;

    public RSNavContext(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

    public void NavigateTo(string relativeUri)
    {
        _navigationManager.NavigateTo(_navigationManager.BaseUri + relativeUri);
    }

    public void NavigateBack(Page pageContext, Album? album = null)
    {
        switch (pageContext)
        {
            case Page.AllRecords:
                NavigateTo("records");
                return;

            case Page.SingleRecord:
                NavigateTo($"record/{album.Id}");
                return;

            case Page.EditRecord:
                NavigateTo($"record/{album.Id}");
                return;
        }
        NavigateTo("records");
    }

}
