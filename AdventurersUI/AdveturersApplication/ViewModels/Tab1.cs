using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurers.ViewModels
{
    public class Tab1 : TabItemViewModel
    {
        public Tab1()
        {            
            Title = "Главная";
            ContentText = "Добро пожаловать в приложение";
        }
    }
}
