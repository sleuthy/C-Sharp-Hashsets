using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();
            
            // Add four of your favorite car model names to the set.
            Showroom.Add("Corvette");
            Showroom.Add("Mazda");
            Showroom.Add("VW");
            Showroom.Add("Convertible");
            
            // Print to the console how many cars are in your show room.
            Console.WriteLine("Total number of cars: ");
            Console.WriteLine(Showroom.Count);

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Corvette");
            
            // Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine("Total cars with added Corvette: ");
            Console.WriteLine(Showroom.Count);

            // Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();

            UsedLot.Add("Buick");
            UsedLot.Add("Civic");

            // Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            Console.WriteLine("Showroom with UsedLot: ");
            foreach (string car in Showroom){
                Console.WriteLine(car);
            }

            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("VW");
            Console.WriteLine("Showroom with VW sold: ");
            foreach(string remainder in Showroom){
                Console.WriteLine(remainder);
            }

            // Now create another HashSet of cars in a variable Junkyard. 
            HashSet<string> Junkyard = new HashSet<string>();

            // Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. 
            // In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            Junkyard.Add("Ford Explorer");
            Junkyard.Add("Corvette");
            Junkyard.Add("Buick");
            Junkyard.Add("Prius");

            // Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            // Junkyard.IntersectWith(Showroom);
            // Console.WriteLine("Junkyard intersects with Showroom: ");
            // foreach (string junk in Junkyard){
            //     Console.WriteLine(junk);
            // }

            // Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);
            Console.WriteLine("Junkyard and Showroom combined: ");
            foreach (string combo in Showroom){
                Console.WriteLine(combo);
            }
            
            // Use the Remove() method to remove any cars that you acquired from the junkyard that you want in your showroom.
            Showroom.Remove("Civic");
            Console.WriteLine("Showroom with Civic removed: ");
            foreach (string nocivic in Showroom){
                Console.WriteLine(nocivic);
            }
        }
    }
}

