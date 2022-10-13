using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{


    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Citizen> citizens = new List<Citizen>();

            List<Rebel> rebels = new List<Rebel>();


            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input.Length==4)
                {
                    Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    citizens.Add(citizen);


                }
                else if (input.Length==3)
                {
                    Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    rebels.Add(rebel);

                }
            }

            List<string> listOfNames = new List<string>();

            string name = Console.ReadLine();

            while (name!="End")
            {
                listOfNames.Add(name);

                name = Console.ReadLine();
            }

            int food = 0;

            foreach (Citizen citizen in citizens)
            {

                foreach (string nameOfcitizen in listOfNames)
                {
                    if (nameOfcitizen== citizen.Name)
                    {
                        citizen.BuyFood();
                    }
                }
            }

            foreach (Rebel rebel in rebels)
            {

                foreach (string nameOfcitizen in listOfNames)
                {
                    if (nameOfcitizen == rebel.Name)
                    {
                        rebel.BuyFood();
                    }
                }
            }

            citizens.ForEach(x => food += x.Food);
            rebels.ForEach(x=>food+=x.Food);

            Console.WriteLine(food);

        }
    }
}