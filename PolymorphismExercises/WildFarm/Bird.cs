using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Bird : Animal
    {
        public Bird(string name, double weight, int foodeaten,double wingSize) : base(name, weight, foodeaten)
        {
            this.WingSize=wingSize;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
        public double WingSize { get; set; }
    }
}
