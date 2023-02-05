namespace Uthingo.ViewModels;

internal class SplashPageViewModel : IPageLifecycleAware
{
    private INavigationService _navigationService { get; }

    public SplashPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        OnAppearing();
    }

    public void OnAppearing()
    {
        _navigationService.CreateBuilder()
            .UseAbsoluteNavigation()
            .AddNavigationSegment("/MainPage/NavigationPage/DashboardPage")
            .Navigate();
    }

    public void OnDisappearing()
    {

    }
}