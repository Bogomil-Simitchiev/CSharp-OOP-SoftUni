using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public interface IRobot
    {
        string Model { get; set; }

        int Id { get; set; }

    }
    public class Robot : IRobot
    {
        public string Model { get; set ; }
        public int Id { get; set; }
    }
}
