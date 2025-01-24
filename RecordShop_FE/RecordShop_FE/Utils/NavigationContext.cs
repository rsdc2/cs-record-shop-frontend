
using Microsoft.AspNetCore.Components;

namespace RecordShop;

public class NavigationContext
{
    NavigationManager _navigationManager;

    //public Page Page { 
    //    get => _navigationManager.Uri switch
    //    {

    //    }
            
    //}

    public NavigationContext(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
    }

}
