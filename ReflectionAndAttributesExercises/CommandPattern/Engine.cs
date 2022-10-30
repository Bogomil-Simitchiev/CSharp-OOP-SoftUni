using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter _interpreter;

        public Engine(ICommandInterpreter interpreter)
        {
            _interpreter = interpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    string result = _interpreter.Read(input);

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
               
            }
        }
    }
}