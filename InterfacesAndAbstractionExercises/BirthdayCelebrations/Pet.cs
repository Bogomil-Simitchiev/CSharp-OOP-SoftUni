using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{

    public interface IPet
    {
        string Name { get; set; }

        string Birthday { get; set; }

    }
    public class Pet : IPet
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set ; }
        public string Birthday { get; set ; }
    }
}
