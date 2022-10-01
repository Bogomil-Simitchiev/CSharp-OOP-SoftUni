using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Fish fish = new Fish("Sharan", 2.55m);
            Console.WriteLine(fish.Grams);
            Dessert dessert = new Dessert("Cake", 3, 25, 700);
            Console.WriteLine(dessert.Grams);

            Cake cake = new Cake("Chocolate");
            Console.WriteLine(cake.Calories);
        }
    }
}