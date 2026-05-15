using Adventurers.Dates;
using Adventurers.Dates.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Adventurers.ViewModels
{
    public class Activity
    {
        private People Gid { get; set; }
        public string Plase {get; set;} 
        public string GidName { get; set;}
        public Locations Location { get; set;}
        public int AdventurersCount { get; set;}
        public int DifficultsLevel { get; set;}
        public List<People> Adventurers { get; set;}

        public Activity(string plase, People gid, Locations location, int adventurerCount,
                        int difficultsLevel, List<People>? adventurers = null)
        {
            Plase = plase;
            Gid = gid;
            GidName = Gid.Name;
            Location = location;
            AdventurersCount = adventurerCount;
            DifficultsLevel = difficultsLevel;
            Adventurers = adventurers ?? new List<People>();
        }
    }
}
