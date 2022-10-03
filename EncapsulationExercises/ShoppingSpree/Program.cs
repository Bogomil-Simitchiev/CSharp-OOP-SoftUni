using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree 
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> inputForPeople = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> inputForProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                for (int i = 0; i < inputForPeople.Count; i++)
                {
                    string[] splited = inputForPeople[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    string nameOfPerson = splited[0];
                    int money = int.Parse(splited[1]);
                    Person currentPerson = new Person(nameOfPerson, money);
                    people.Add(currentPerson);
                }
                for (int i = 0; i < inputForProducts.Count; i++)
                {
                    string[] splited = inputForProducts[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    string nameOfProduct = splited[0];
                    int cost = int.Parse(splited[1]);
                    Product product = new Product(nameOfProduct, cost);

                    products.Add(product);
                }



                //Peter=11;George=4
                //Bread=10;Milk=2;
                //Peter Bread
                //George Milk
                //George Milk
                //Peter Milk
                //END
                string command = Console.ReadLine();
                while (command != "END")
                {
                    string[] splitedInfo = command.Split(" ");
                    string personName = splitedInfo[0];
                    string productName = splitedInfo[1];

                    foreach (Person person in people)
                    {
                        if (person.Name == personName)
                        {
                            foreach (Product pr in products)
                            {
                                if (pr.Name == productName)
                                {
                                    if (person.Money >= pr.Cost)
                                    {
                                        person.Money -= pr.Cost;
                                        Console.WriteLine($"{personName} bought {productName}");
                                        person.Products.Add(productName);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{personName} can't afford {productName}");
                                    }

                                }
                            }
                        }
                    }

                    command = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            foreach (Person person in people)
            {
                if (person.Products.Count==0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Products)}");
                }
            }
        }
    }
}
