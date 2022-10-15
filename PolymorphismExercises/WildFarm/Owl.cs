using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodeaten, double wingSize) : base(name, weight, foodeaten, wingSize)
        {

        }
        public string ProduceSound()
        {
            return "Hoot Hoot";
        }

    }
}
