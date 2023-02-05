using Uthingo.Views;

namespace Uthingo.ViewModels;

public class DashboardPageViewModel : ViewModelBase
{
    public DashboardPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
    {
        Title = "Uthingo App";
    }
}