using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight,int foodeaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodeaten;
        }
        public string Name { get; set; }

        public int FoodEaten { get; set; }
        public double Weight { get; set; }
    }
}
