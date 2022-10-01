using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Knight knight = new Knight("az", 12);
            Console.WriteLine(knight);
            
        }
    }
}