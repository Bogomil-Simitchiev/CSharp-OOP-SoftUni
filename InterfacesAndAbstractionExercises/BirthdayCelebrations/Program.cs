using BirthdayCelebrations;
using System;
using System.Text.RegularExpressions;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {

         
            List<Citizen> citizens = new List<Citizen>();

            List<Pet> pets = new List<Pet>();


            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] splited = command.Split(" ");

                string first = splited[0];
                if (first=="Citizen")
                {

                    Citizen citizen = new Citizen(splited[1], int.Parse(splited[2]), splited[3], splited[4]);
                    citizens.Add(citizen);


                }
                else if (first=="Pet")
                {

                    Pet pet = new Pet(splited[1], splited[2]);

                    pets.Add(pet);

                }


                command = Console.ReadLine();
            }

            string date = Console.ReadLine();

            string regex = @"(?<year>[0-9]{4})";

            foreach (Citizen citizen in citizens)
            {

                Match match = Regex.Match(citizen.Birthday, regex);

                if (match.Value==date)
                {
                    Console.WriteLine(citizen.Birthday);
                   
                }
               

            }
            foreach (Pet pet in pets)
            {

                Match match = Regex.Match(pet.Birthday, regex);

                if (match.Value == date)
                {
                    Console.WriteLine(pet.Birthday);
                  
                }
            }

           

        }
    }
}