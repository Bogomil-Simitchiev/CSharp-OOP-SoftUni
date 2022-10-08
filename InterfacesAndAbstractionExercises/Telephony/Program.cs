using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public interface IBrowsable
    {
        List<string> Webs { get; }
        void Browse();
    }
    public interface ICallable
    {
        List<string> PhoneNumber { get; }
        void Call();
    }
    public class Smartphone : ICallable, IBrowsable
    {
        private List<string> phoneNumber;
        private List<string> webs;

        public Smartphone(List<string> phoneNumber, List<string> webs)
        {
            this.PhoneNumber = phoneNumber;
            this.Webs = webs;
        }

        public List<string> PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public List<string> Webs
        {
            get { return webs; }
            set { webs = value; }
        }

        public void Browse()
        {
            for (int i = 0; i < this.Webs.Count; i++)
            {
                string pattern = @"^[^0-9]+$";
                if (!Regex.IsMatch(this.Webs[i], pattern))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {this.Webs[i]}!");
                }
            }
        }

        public void Call()
        {
            string pattern = @"^[^\D]+$";

            for (int i = 0; i < this.PhoneNumber.Count; i++)
            {
                if (!Regex.IsMatch(this.PhoneNumber[i], pattern))
                {
                    Console.WriteLine("Invalid number!");
                }
                else if (this.PhoneNumber[i].Length == 7)
                {
                    Console.WriteLine($"Dialing... {this.PhoneNumber[i]}");
                }
                else if (this.PhoneNumber[i].Length==10)
                {
                    Console.WriteLine($"Calling... {this.PhoneNumber[i]}");
                }
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {

                var phoneNumbers = Console.ReadLine().Split().ToList();
                var webs = Console.ReadLine().Split().ToList();

                Smartphone smartphone = new Smartphone(phoneNumbers, webs);

                smartphone.Call();
                smartphone.Browse();

            }
        }
    }
}