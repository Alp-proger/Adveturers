using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Adventurers.ViewModels
{
    public class AdventurersViewModel : TabItemViewModel
    {
        public ObservableCollection<Activity> Activities { get; set; } = [];
    }
}
