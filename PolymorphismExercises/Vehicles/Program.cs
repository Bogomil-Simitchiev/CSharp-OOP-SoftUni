﻿using System;
using System.Text.Json;
using Vehicles;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            Vehicle vehicle;

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (info[1].ToLower() == "car")
                {
                    vehicle = car;
                }
                else if (info[1].ToLower() == "truck")
                {
                    vehicle = truck;
                }
                else
                {
                    vehicle = bus;
                }

                string command = info[0];

                try
                {
                    if (command.ToLower() == "drive")
                    {
                        vehicle.Drive(double.Parse(info[2]));
                    }
                    else if (command.ToLower() == "driveempty")
                    {
                        Bus currentBuss = vehicle as Bus;
                        currentBuss.DriveEmpty(double.Parse(info[2]));
                    }
                    else
                    {
                        vehicle.Refuel(double.Parse(info[2]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);



        }
    }
}