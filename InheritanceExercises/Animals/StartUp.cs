using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            string input = Console.ReadLine();
            while (input!="Beast!")
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                int age = int.Parse(info[1]);
                string gender = info[2];
                switch (input)
                {
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        list.Add(cat);
                        break;
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        list.Add(dog);

                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        list.Add(frog);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        list.Add(tomcat);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        list.Add(kitten);
                        break;
                }



                input = Console.ReadLine();
            }

            foreach (Animal animal in list)
            {
                Console.WriteLine($"{animal.GetType().Name}");
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }

        }
    }
}
