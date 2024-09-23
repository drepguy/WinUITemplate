using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUIStudio.ViewModels;

public partial class BlankViewModel : ObservableObject
{
    public BlankViewModel()
    {

    }

    [ObservableProperty]
    private string title = "Hallo Welt!";
}
