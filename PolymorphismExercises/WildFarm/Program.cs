using System;
using System.Collections.Generic;
using WildFarm;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Cat Sammy 1.1 Home Persian
            Vegetable 4
            End
            */
            List<Animal> listOfAnimals = new List<Animal>();


            string input = Console.ReadLine();

            while (input!="End")
            {
                string[] splitedInfoAnimal = input.Split();

                string[] foodInfo = Console.ReadLine().Split();

                //Food info

                string typeOfFood = foodInfo[0];
                int foodEaten = int.Parse(foodInfo[1]);


                string typeAnimal = splitedInfoAnimal[0];

                if (typeAnimal=="Cat" || typeAnimal == "Tiger")
                {

                    string name = splitedInfoAnimal[1];
                    double weight = double.Parse(splitedInfoAnimal[2]);
                    string livingRegion = splitedInfoAnimal[3];
                    string breed = splitedInfoAnimal[4];


                    if (typeAnimal=="Cat")
                    {
                        if (typeOfFood=="Vegetable" || typeOfFood=="Meat")
                        {
                            double weightOfCat = (foodEaten * 0.30) + weight;
                            Cat cat = new Cat(name, weightOfCat, foodEaten, livingRegion, breed);
                            Console.WriteLine(cat.ProduceSound());
                            listOfAnimals.Add(cat);
                        }
                        else
                        {
                            Cat cat = new Cat(name, weight, 0, livingRegion, breed);
                            Console.WriteLine(cat.ProduceSound());
                            listOfAnimals.Add(cat);
                            Console.WriteLine($"Cat does not eat {typeOfFood}!");
                        }
                      

                    }
                    else
                    {
                        if (typeOfFood == "Meat")
                        {
                            double weightOfTiger = (foodEaten * 1) + weight;
                            Tiger tiger = new Tiger(name, weightOfTiger, foodEaten, livingRegion, breed);
                            Console.WriteLine(tiger.ProduceSound());
                            listOfAnimals.Add(tiger);
                        }
                        else
                        {
                            Tiger tiger = new Tiger(name, weight, 0, livingRegion, breed);
                            Console.WriteLine(tiger.ProduceSound());
                            listOfAnimals.Add(tiger);
                            Console.WriteLine($"Tiger does not eat {typeOfFood}!");
                        }

                    }

                }
                else if (typeAnimal == "Owl" || typeAnimal=="Hen")
                {
                    string name = splitedInfoAnimal[1];
                    double weight = double.Parse(splitedInfoAnimal[2]);
                    double wingSize = double.Parse(splitedInfoAnimal[3]);


                    if (typeAnimal == "Owl")
                    {
                        if (typeOfFood=="Meat")
                        {
                            double weightOfOwl = (foodEaten * 0.25) + weight;
                            Owl owl = new Owl(name, weightOfOwl, foodEaten, wingSize);
                            Console.WriteLine(owl.ProduceSound());
                            listOfAnimals.Add(owl);
                        }
                        else
                        {
                            Owl owl = new Owl(name, weight, 0, wingSize);
                            Console.WriteLine(owl.ProduceSound());
                            listOfAnimals.Add(owl);
                            Console.WriteLine($"Owl does not eat {typeOfFood}!");
                        }
                        
                    }
                    else
                    {
                       
                        double weightOfHen = (foodEaten * 0.35) + weight;
                        Hen hen = new Hen(name,weightOfHen,foodEaten,wingSize);
                        Console.WriteLine(hen.ProduceSound());
                        listOfAnimals.Add(hen);
                       

                    }

                }
                else if (typeAnimal=="Dog"||typeAnimal=="Mouse")
                {

                    string name = splitedInfoAnimal[1];
                    double weight = double.Parse(splitedInfoAnimal[2]);
                    string livingRegion = splitedInfoAnimal[3];


                    if (typeAnimal == "Mouse")
                    {
                        if (typeOfFood == "Vegetable"||typeOfFood=="Fruit")
                        {
                            double weightOfMouse = (foodEaten * 0.10) + weight;
                            Mouse mouse = new Mouse(name, weightOfMouse, foodEaten, livingRegion);
                            Console.WriteLine(mouse.ProduceSound());
                            listOfAnimals.Add(mouse);
                        }
                        else
                        {
                            Mouse mouse = new Mouse(name, weight, 0, livingRegion);
                            Console.WriteLine(mouse.ProduceSound());
                            listOfAnimals.Add(mouse);
                            Console.WriteLine($"Mouse does not eat {typeOfFood}!");
                        }

                    }
                    else
                    {
                        if (typeOfFood == "Meat")
                        {
                            double weightOfDog = (foodEaten * 0.40) + weight;
                            Dog dog = new Dog(name, weightOfDog, foodEaten, livingRegion);
                            Console.WriteLine(dog.ProduceSound());
                            listOfAnimals.Add(dog);
                        }
                        else
                        {
                            Dog dog = new Dog(name, weight, 0, livingRegion);
                            Console.WriteLine(dog.ProduceSound());
                            listOfAnimals.Add(dog);
                            Console.WriteLine($"Dog does not eat {typeOfFood}!");
                        }

                    }


                }

                input = Console.ReadLine(); 
            }

            foreach (Animal currentAnimal in listOfAnimals)
            {
                Console.WriteLine(currentAnimal.ToString());
            }

        }
    }
}