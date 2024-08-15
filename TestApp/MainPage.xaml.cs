using TestApp.ViewModels;

namespace TestApp;

public partial class MainPage
{
    public MainPage(FeedViewModel feedViewModel)
    {
        InitializeComponent();
        
        BindingContext = feedViewModel;
    }
}