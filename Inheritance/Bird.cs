using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Noise = "tapping and clattering";
            Name = "Toucan";
            ContinentOfOrigin = "South America";
            NumberOfLegs = 2;
        }

        public bool DoesItFly { get; set; } 
        public bool DoesItSwim { get; set; }
        public string FavoriteFood { get; set; }
        public string Climate { get; set; }


        public void BirdBrain()
        {
            Console.WriteLine($"Good day sir or ma'am! Welcome to the VIP tour at the San Diego Zoo! \nToday we will be talking abou the {Name}!" +
                $" Now I am sure that when you think about the {Name}, \nyou think of the continent that it's from, which of course is {ContinentOfOrigin}.\n" +
                $"Did you know that it's favorite food is {FavoriteFood} and it makes sounds that sound like {Noise}! \nIf " +
                $"you are wondering what climate it is used to, that would be {Climate}. \nNow of course it is {DoesItFly} that it flies, but did you know that " +
                $"it is {DoesItSwim} to say that they swim? \nBefore we end the tour I am sure you were wondering just how many legs does the {Name} have?!\n" +
                $"Haters will say it's fake but it has {NumberOfLegs} legs! \nThank you for joining us on this tour! Goodbye! ");

        }

    }
}
