using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurers.ViewModels
{
    public class TabItemViewModel : ReactiveObject
    {
        private string _title = "";
        private string _contentText = "";        

        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        public string ContentText
        {
            get => _contentText;
            set => this.RaiseAndSetIfChanged(ref _contentText, value);
        }
    }
}
