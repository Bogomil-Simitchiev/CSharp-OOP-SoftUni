using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            SportCar sportCar = new SportCar(100, 5);
            sportCar.Drive(0.2);
            Console.WriteLine(sportCar.Fuel);
            
        }
    }
}
