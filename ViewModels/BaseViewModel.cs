using CommunityToolkit.Mvvm.ComponentModel;

namespace WeatherApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public string? title;
    }
}
