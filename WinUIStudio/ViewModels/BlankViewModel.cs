using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUIStudio.ViewModels;

[ObservableObject]
public partial class BlankViewModel
{
    public BlankViewModel()
    {
    }

    [ObservableProperty]
    private string title = "Hallo Welt!";
}
