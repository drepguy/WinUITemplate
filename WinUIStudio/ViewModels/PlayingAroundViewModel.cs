using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUIStudio.ViewModels;

public partial class PlayingAroundViewModel : ObservableObject
{
    public PlayingAroundViewModel()
    {
    }

    [ObservableProperty]
    private string title = "Hallo Playground!";
}
