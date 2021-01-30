using LunchBuddies.EatingOut;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.LunchBuddy
{
    class Buddy
    {
        public string FirstName { get; set; }
        public string LastName { get; }

        public Buddy(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string eat()
        {
            Restaurant restuarantChoices = new Restaurant();
            Console.WriteLine($"My buddy {FirstName} {LastName} is waiting at {restuarantChoices.Name}, I should get there quicker!!!");
            return restuarantChoices.Name;
        }

        public void eat(string food)
        {
            Console.WriteLine($"My buddy {FirstName} {LastName} was eating {food} in the office!!!");
        }

        public void eat(List<Buddy> companions)
        {
            Restaurant restuarantChoicesTwo = new Restaurant();
            int count = 0;

            Console.Write("My friends ");
            foreach (var companion in companions)
            {
                count++;
                if(companions.Count == count)
                {
                    Console.Write($"and {companion.FirstName} ");
                }
                else
                {
                    Console.Write($"{companion.FirstName}, ");
                }
                
            }
            Console.Write($"are waiting for me at {restuarantChoicesTwo.Name}");
        }

        public void eat(string food, List<Buddy> companions)
        {
            Restaurant restuarantChoicesThree = new Restaurant();
            int count = 0;

            Console.Write("My friends ");
            foreach (var companion in companions)
            {
                count++;
                if (companions.Count == count)
                {
                    Console.Write($"and {companion.FirstName} ");
                }
                else
                {
                    Console.Write($"{companion.FirstName}, ");
                }

            }
            Console.Write($"are waiting for me at {restuarantChoicesThree.Name} and they all ordered {food}!");
        }
    }
}
