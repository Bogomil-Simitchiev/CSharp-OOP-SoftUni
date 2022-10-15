using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Mammal : Animal
    {
        public Mammal(string name, double weight, int foodeaten, string livingRegion) : base(name, weight, foodeaten)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
        public string LivingRegion { get; set; }
    }
}
