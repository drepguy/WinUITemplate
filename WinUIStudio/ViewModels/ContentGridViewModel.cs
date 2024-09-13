using System.Collections.ObjectModel;
using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using WinUIStudio.Contracts.Services;
using WinUIStudio.Contracts.ViewModels;
using WinUIStudio.Core.Contracts.Services;
using WinUIStudio.Core.Models;

namespace WinUIStudio.ViewModels;


// using primary constructor
public partial class ContentGridViewModel(INavigationService navigationService, ISampleDataService sampleDataService) : ObservableRecipient, INavigationAware
{
    private readonly INavigationService _navigationService = navigationService;
    private readonly ISampleDataService _sampleDataService = sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = [];

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetContentGridDataAsync();
        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    [RelayCommand]
    private void OnItemClick(SampleOrder? clickedItem)
    {
        if (clickedItem != null)
        {
            _navigationService.SetListDataItemForNextConnectedAnimation(clickedItem);
            _navigationService.NavigateTo(typeof(ContentGridDetailViewModel).FullName!, clickedItem.OrderID);
        }
    }
}
