using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, string food)
        {
            Name = name;
            Food = food;
        }

        public string Name { get; set; }
        public string Food { get; set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.Food}";
        }
    }
}
