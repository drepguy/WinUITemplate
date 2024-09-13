using Microsoft.UI.Xaml.Controls;

using WinUIStudio.ViewModels;

namespace WinUIStudio.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
