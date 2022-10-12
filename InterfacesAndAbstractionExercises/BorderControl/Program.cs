using BorderControl;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
            List<ICitizen> citizens = new List<ICitizen>();

            List<IRobot> robots = new List<IRobot>();

            bool whoIsFirst = false;



            while (command!="End")
            {
                string[] splitedInfo = command.Split(" ");
                if (splitedInfo.Length == 3)
                {
                    Citizen currentCitizen = new Citizen(splitedInfo[0], int.Parse(splitedInfo[1]), splitedInfo[2]);

                    citizens.Add(currentCitizen);

                }
                else
                {
                    Robot currentRobot = new Robot(splitedInfo[0], splitedInfo[1]);

                    robots.Add(currentRobot);


                }

                command = Console.ReadLine();
            }

            string id = Console.ReadLine();

              
                foreach (Robot robot in robots)
                {
                    string substringFromId = robot.Id.Substring(robot.Id.Length - id.Length, id.Length);
                    if (id == substringFromId)
                    {
                        Console.WriteLine(robot.Id);
                    }
                }
                foreach (Citizen citizen in citizens)
                {
                    string substringFromId = citizen.Id.Substring(citizen.Id.Length - id.Length, id.Length);
                    if (id == substringFromId)
                    {
                        Console.WriteLine(citizen.Id);
                    }
                }
 
               

        }
    }
}