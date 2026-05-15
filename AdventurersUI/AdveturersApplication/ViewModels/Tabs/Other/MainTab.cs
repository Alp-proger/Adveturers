using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurers.ViewModels
{
    public class MainTab : TabItemViewModel
    {
        public MainTab()
        {            
            Title = "Главная";
            ContentText = "Добро пожаловать в приложение";
        }
    }
}
