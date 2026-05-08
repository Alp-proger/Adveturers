namespace Adventurers.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        //public string Greeting { get; } = "Welcome to Avalonia!";
        public VelcomeViewModel SimpleViewModel { get; } = new VelcomeViewModel();
    }
}
