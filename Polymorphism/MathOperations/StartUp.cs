using System;

namespace Operations 
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(2,3));
            Console.WriteLine(mo.Add(2.5, 3.5));
            Console.WriteLine(mo.Add(2.5m, 3.5m));



        }
    }
}