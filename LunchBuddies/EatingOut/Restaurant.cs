using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.EatingOut
{
    class Restaurant
    {
        public string Name { get; }
        private List<string> _restuarantNames { get; } = new List<string>();

        public Restaurant()
        {
            var random = new Random();
            createList();
            int index = random.Next(_restuarantNames.Count);
            Name = _restuarantNames[index];
        }

        public void createList()
        {
            _restuarantNames.Add("Chili's");
            _restuarantNames.Add("Checkers");
            _restuarantNames.Add("LongHorn");
        }
        
    }
}
