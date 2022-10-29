using System;
using System.Runtime.CompilerServices;

namespace AuthorProblem
{
    [AuthorAttribute("Mitko")]
    public class StartUp
    {
        [AuthorAttribute("Bogi")]
        static void Main(string[] args)
        {

            var tracker = new Tracker();
            Console.WriteLine(tracker.PrintMethodsByAuthor());


        }
    }
}