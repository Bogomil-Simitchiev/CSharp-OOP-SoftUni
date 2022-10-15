using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Feline : Mammal
    {
        public Feline(string name, double weight, int foodeaten, string livingRegion, string breed) : base(name, weight, foodeaten, livingRegion)
        {
            this.Breed = breed;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public string Breed { get; set; }
    }
}
