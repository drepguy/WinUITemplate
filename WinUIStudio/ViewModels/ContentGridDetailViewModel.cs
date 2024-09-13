using CommunityToolkit.Mvvm.ComponentModel;

using WinUIStudio.Contracts.ViewModels;
using WinUIStudio.Core.Contracts.Services;
using WinUIStudio.Core.Models;

namespace WinUIStudio.ViewModels;

// this is primary constructor
public partial class ContentGridDetailViewModel(ISampleDataService sampleDataService) : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService = sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
