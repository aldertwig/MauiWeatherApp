using CommunityToolkit.Mvvm.ComponentModel;

namespace WeatherApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? title;
    }
}
