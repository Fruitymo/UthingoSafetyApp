namespace Uthingo.ViewModels;

public class MainPageViewModel : ViewModelBase
{
    private INavigationService _navigationService { get; }
    public DelegateCommand<string> NavigateCommand { get; }

    private void OnNavigateCommandExecuted(string uri)
    {
        _navigationService.NavigateAsync(uri)
            .OnNavigationError(ex => Console.WriteLine(ex));
    }

    public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
    {
        _navigationService = navigationService;
        NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
    }
}