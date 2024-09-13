﻿using Microsoft.UI.Xaml.Controls;

using WinUIStudio.ViewModels;

namespace WinUIStudio.Views;

public sealed partial class BlankPage : Page
{
    public BlankViewModel ViewModel
    {
        get;
    }

    public BlankPage()
    {
        ViewModel = App.GetService<BlankViewModel>();
        InitializeComponent();
    }
}
