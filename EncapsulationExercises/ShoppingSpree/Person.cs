using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;

        public List<string> Products { get; set; }
        public Person(string name, int money)
        {
           this.Name = name;
            this.Money = money;
            this.Products = new List<string>();
           
        }
        

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Money
        {
            get { return this.money; }
            set
            {
                if (value<0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }
        

    }
}
