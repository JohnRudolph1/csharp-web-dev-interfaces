using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;




            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine("Before:\n");
            foreach (Flavor flavor in availableFlavors)
            {

                Console.WriteLine(flavor.Name);
            }
            availableFlavors.Sort(new FlavorComparer());
            Console.WriteLine();
            Console.WriteLine("After:\n");
            foreach (Flavor flavor in availableFlavors)
            {

                Console.WriteLine(flavor.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Before:\n");
            foreach (Cone cone in availableCones)
            {

                Console.WriteLine($"{cone.Name}: {cone.Cost} ");
            }
            availableCones.Sort(new ConeComparer());
            Console.WriteLine();
            Console.WriteLine("After:\n");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"\t\t\t{cone.Name}: {cone.Cost} ");



                
    
            }
        }
    }
}


