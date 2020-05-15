using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************WELCOME TO ARISTHER'S STAND**********************");
            Console.WriteLine("We have a wide variety of typical unhealthy foods.");
            Console.WriteLine("Please Choose: Burger, Sandwich, Hotdog, Ramen, Chocolate, Beer, Ice Cream, or Donuts");

            string[] validValues = { "Burger", "Sandwich", "Hotdog", "Ramen", "Chocolate", "Beer", "Ice Cream", "Donuts" };
            double[] prices = { 0.89, 1.23, 4.1, 2.2, 5.5, 76.1, 19.45, 11.6 };

            Console.WriteLine("Type in your choice to check whether we have it in stock and its price");


            string orderName = Console.ReadLine();
            bool itemInStock = false;
            double price = 0;
            for(int i = 0; i < validValues.Length; i++)
            {
                if (orderName == validValues[i])
                {
                    price = prices[i];
                    itemInStock = true;
                    break;
                }
            }

            if (itemInStock == true)
            {
                Console.WriteLine(orderName + " is in stock and it's price is {0}", price.ToString("C"));
            }
            
            if (itemInStock == false)
            {
                Console.WriteLine("Nope, not here");
            }

            Console.ReadLine();

        }
    }
}
