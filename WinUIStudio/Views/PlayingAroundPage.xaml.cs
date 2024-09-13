using Microsoft.UI.Xaml.Controls;
using WinUIStudio.ViewModels;

namespace WinUIStudio.Views;

public sealed partial class PlayingAroundPage : Page
{
    public PlayingAroundViewModel ViewModel
    {
        get;
    }

    public PlayingAroundPage()
    {
        ViewModel = App.GetService<PlayingAroundViewModel>();
        InitializeComponent();
    }
}
