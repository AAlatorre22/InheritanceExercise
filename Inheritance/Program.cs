using System;
using System.Globalization;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal done
            // give this class 4 members that all Animals have in common done


            // Create a class Bird done
            // give this class 4 members that are specific to Bird done
            // Set this class to inherit from your Animal Class done

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile done
            // Set this class to inherit from your Animal Class done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class done
             *  
             * Creatively display the class member values 
             */

            Bird toucan = new Bird();

            toucan.Climate = "tropical";
            toucan.FavoriteFood = "crickets";
            toucan.DoesItFly = true;
            toucan.DoesItSwim = false;
            


            //Console.WriteLine($"{toucan.BirdBrain}");
            toucan.BirdBrain();

            Console.WriteLine();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class donr
             *  
             * Creatively display the class member values 
             */

            Reptile komodoDragon = new Reptile() 
            { 
                ContinentOfOrigin = "Asia", 
                NumberOfLegs = 4, 
                Name = "Komodo Dragon", 
                Noise = "HISSSS", 
                DoesItHaveAShell = false, 
                DoesItEatMeat = true, 
                NickName = "Ora", 
                Weight = 200
            };

            //komodoDragon.Name = "Komodo Dragon";
            //komodoDragon.Weight =  200;
            //komodoDragon.NickName = "Ora";
            //komodoDragon.NumberOfLegs = 4;
            //komodoDragon.DoesItHaveAShell = false;
            //komodoDragon.Noise = "HISSSS";
            //komodoDragon.ContinentOfOrigin = "Asia";
            //komodoDragon.DoesItEatMeat = true;


            komodoDragon.DragonBreath();

        }
    }
}
