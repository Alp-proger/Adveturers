using System;
using ReactiveUI;


namespace Adventurers.ViewModels
{
    public class ReactiveViewModel : TabItemViewModel
    {
        private string? _Name;
        public string? Name
        {
            get => _Name;
            set => this.RaiseAndSetIfChanged(ref _Name, value);
        }

        public string Greeting
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return "Привет";
                }
                else
                {
                    return $"Привет, {Name}!";
                }
            }
        }

        public ReactiveViewModel()
        {
            Title = "Reactive view model";
            this.WhenAnyValue(o => o.Name).Subscribe(o => this.RaisePropertyChanged(nameof(Greeting)));
        }
    }
}
