using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;

namespace Adventurers.ViewModels
{
    public partial class MainWindowViewModel : ReactiveObject
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
        public VelcomeViewModel SimpleViewModel { get; } = new VelcomeViewModel();
        public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();


        private int _counter = 2;
        private TabItemViewModel _selectedTab;
        
        public ObservableCollection<TabItemViewModel> Tabs { get; }
        public ReactiveCommand<Unit,  Unit> AddTabCommand { get; }
        public TabItemViewModel SelectedTab
        {
            get => _selectedTab;
            set => this.RaiseAndSetIfChanged(ref _selectedTab, value);
        }
        

        public MainWindowViewModel()
        {
            Tabs = StartTabsCreate();
            SelectedTab = Tabs.First();

            AddTabCommand = ReactiveCommand.Create(AddNewTab);
        }

        private ObservableCollection<TabItemViewModel> StartTabsCreate()
        {
            return new ObservableCollection<TabItemViewModel>()
            {
                new Tab1(),                
                new ReactiveViewModel(),                
                new Tab2()                
            };
        }

        private void AddNewTab()
        {
            _counter++;
            var newTab = new TabItemViewModel
            {
                Title = $"Вкладка {_counter}",
                ContentText = $"Это дингавически созданный контент для вкладки № {_counter}"
            };
            Tabs.Add(newTab);
        }
    }
}
