using Adventurers.Dates.Enums;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adventurers.Dates
{
    public class People
    {
        public string Name = "";
        public int Age;
        public Locations Interest;
        public int ExpirienseLevel;

        public People(string name, int age, Locations interest, int expirienceLevel)
        {
            Name = name;
            Age = age;
            Interest = interest;
            ExpirienseLevel = expirienceLevel;
        }
    }
}
