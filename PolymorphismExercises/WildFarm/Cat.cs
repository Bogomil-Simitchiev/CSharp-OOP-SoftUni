using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, int foodeaten, string livingRegion, string breed) : base(name, weight, foodeaten, livingRegion, breed)
        {

        }
        public string ProduceSound()
        {
            return "Meow";
        }

    }
}
