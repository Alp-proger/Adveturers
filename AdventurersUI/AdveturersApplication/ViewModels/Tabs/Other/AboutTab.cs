using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurers.ViewModels
{
    public class AboutTab : TabItemViewModel
    {
        public AboutTab()
        {
            Title = "О приложении";
            ContentText = "Информация о функциях и разработчиках";
        }
    }
}
