using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() { }
    
        public bool DoesItHaveAShell { get; set; }
        public bool DoesItEatMeat { get; set; }
        public string NickName { get; set; }
        public int Weight { get; set; }

        public void DragonBreath() 
        {
            Console.WriteLine($"G'day mate! We are going to talk about the {Name}! A fierce reptile that goes by the nickname {NickName}." +
                $"\nThe {Name} is from the continent of {ContinentOfOrigin} and makes a {Noise} sound! If you see one in nature, please stay away! \nThey" +
                $" can weigh up to {Weight}lbs and it's {DoesItEatMeat} that it eats meat!" +
                $"\nUnlike turtles, it is {DoesItHaveAShell} to think that they have shells. Unlike birds, the {Name} has {NumberOfLegs} legs!\nThank " +
                $"you for joining us today! Goodbye!");


        }
    
    }
}
