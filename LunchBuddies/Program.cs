using LunchBuddies.LunchBuddy;
using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Buddy friend1 = new Buddy("Kate", "liliana");
            Buddy friend2 = new Buddy("Ecki", "Bieze");
            Buddy friend3 = new Buddy("Sarah", "Magic");

            List<Buddy> Buddies = new List<Buddy>();
            Buddies.Add(friend1);
            Buddies.Add(friend2);
            Buddies.Add(friend3);

            friend1.eat();
            friend1.eat("pizza");
            friend1.eat(Buddies);
            friend1.eat("pizza", Buddies);
        }
    }
}
