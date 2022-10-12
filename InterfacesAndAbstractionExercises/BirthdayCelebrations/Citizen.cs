using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public interface ICitizen
    {
        string Name { get; set; }
        int Age { get; set; }

        string Id { get; set; }
        string Birthday { get; set; }
    }
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set ; }
        public string Birthday { get ; set; }
    }
}
