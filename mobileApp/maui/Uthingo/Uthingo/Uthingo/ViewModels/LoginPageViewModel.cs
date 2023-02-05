using System.Runtime.InteropServices;
using Prism.Navigation;
using Uthingo.Views;

namespace Uthingo.ViewModels;

public class LoginPageViewModel : ViewModelBase
{
    #region Services

    private readonly INavigationService _navigationService;

    #endregion

    #region Commands

    public DelegateCommand LoginCommand => new DelegateCommand( async ()=> await Login());

    #endregion
    #region Constructor

    public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
    {
        _navigationService = navigationService;
        Title = "Login Page";
    }

    #region Mothods

    public async Task Login()
    {
        try
        {

            // _navigationService.CreateBuilder()
            //     .AddTabbedSegment(b =>
            //         b.CreateTab("DashboardPage")
            //          .CreateTab("LoginPage"))
            //     .Navigate();


            _navigationService.CreateBuilder()
                .AddNavigationSegment("LoginPage")
                .Navigate();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    #endregion

    #endregion
}