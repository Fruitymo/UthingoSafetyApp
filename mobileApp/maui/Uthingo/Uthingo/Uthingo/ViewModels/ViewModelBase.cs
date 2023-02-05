namespace Uthingo.ViewModels;

public class ViewModelBase : BindableBase, IInitialize, INavigatedAware, IPageLifecycleAware
{
    #region Properties

    protected INavigationService NavigationService { get; set; }
    protected IPageDialogService PageDialogService { get; set; }

    public string Title { get; set; }
    public bool IsBusy { get; set; }

    #endregion

    #region Constructor

    public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
    {
        NavigationService = navigationService;
        PageDialogService = pageDialogService;
    }

    #endregion

    #region INavigationAware

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {

    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {

    }

    #endregion

    #region IInitializeAsync

    public virtual Task InitializeAsync(INavigationParameters parameters)
    {
        return Task.FromResult("");
    }

    #endregion

    #region IInitialize

    public virtual void Initialize(INavigationParameters parameters)
    {

    }

    #endregion

    public void OnAppearing()
    {
        //---
    }

    public void OnDisappearing()
    {
        //=====
    }
}