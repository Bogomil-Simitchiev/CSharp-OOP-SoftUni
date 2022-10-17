using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = 0;


            while (count != 3)
            {
                string[] split = Console.ReadLine().Split();

                try
                {
                    if (split.Length == 3)
                    {

                        if (split[0] == "Replace")
                        {
                            int index = int.Parse(split[1]);
                            int element = int.Parse(split[2]);
                            list[index] = element;
                            

                        }
                        else if (split[0] == "Print")
                        {
                            int start = int.Parse(split[1]);
                            int end = int.Parse(split[2]);
                            Console.WriteLine(String.Join(", ",list.GetRange(start,end-start+1)));
                        }

                    }
                    else if (split.Length == 2)
                    {
                        int index = int.Parse(split[1]);
                        Console.WriteLine(list[index]);
                    }
                }
                catch (FormatException)
                {
                    count++;
                    Console.WriteLine("The variable is not in the correct format!");
                }

                catch (Exception)
                {
                    count++;
                    Console.WriteLine("The index does not exist!");
                }




            }


            Console.WriteLine(String.Join(", ", list));




        }
    }
}
