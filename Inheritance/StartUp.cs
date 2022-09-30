using System;
using System.Net.Http.Headers;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Examples
             StackOfStrings stackOfStrings = new StackOfStrings();
            Console.WriteLine(stackOfStrings.IsEmpty());
            stackOfStrings.AddRange(new string[] { "Bogi","Bogi"});

            Console.WriteLine(stackOfStrings.IsEmpty());
            
             RandomList randomList = new RandomList();

            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");

            Console.WriteLine(randomList.RandomString());
            randomList.RemoveRandomString();
            Console.WriteLine(randomList.Count);
            
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
       

        }
    }
}
