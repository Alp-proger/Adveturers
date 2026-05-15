using Adventurers.Dates;
using Adventurers.Dates.Enums;

namespace Adventurers.ViewModels
{
    public class Montain : AdventurersViewModel
    {        
        public Montain()
        {
            Title = "Горы и скалолазание";
            ContentText = Title;
            Activities = new ()
            {
                new Activity("Архыз", new People("Катя", 25, Locations.mountain, 3),
                                Locations.mountain, 5, 1),
                new Activity("Тырныауз", new People("Костя", 42, Locations.mountain, 5),
                                Locations.mountain, 5, 3),
                new Activity("Кязи", new People("Сергей", 25, Locations.mountain, 5),
                                Locations.mountain, 5, 4)
            }; 
        }
    }
}
