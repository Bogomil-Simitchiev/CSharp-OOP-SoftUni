using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        //Hello Bogi
        public string Read(string args)
        {
            string[] splitInfo = args.Split();

            string[] parameters = splitInfo.Skip(1).ToArray();

            string className = splitInfo[0]+"Command";

            Type type = Assembly.GetCallingAssembly().GetTypes().Where(x => x.Name == className).FirstOrDefault();

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command!");

            }

            ICommand command = (ICommand)Activator.CreateInstance(type);

            string result = command.Execute(parameters);

            return result;

        }
    }
}