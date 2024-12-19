using WeatherApp.ViewModels;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
            mainViewModel.Title = "Weather Forecast";
        }
    }
}
