using Uthingo.ViewModels;
using Uthingo.Views;

namespace Uthingo;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .OnAppStart(navigationService => navigationService.CreateBuilder()
                .AddNavigationSegment<SplashPageViewModel>()
                .Navigate(HandleNavigationError));

        // builder.RegisterTypes(RegisterTypes)
        //     .OnAppStart(navigationService => navigationService.CreateBuilder()
        //         .AddNavigationSegment("/MainPage/NavigationPage/DashboardPage")
        //         .Navigate(HandleNavigationError));
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
        containerRegistry.RegisterForNavigation<SplashPage, SplashPageViewModel>();
    }

    private static void HandleNavigationError(Exception ex)
    {
        Console.WriteLine(ex);
        System.Diagnostics.Debugger.Break();
    }
}