using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        public string PrintMethodsByAuthor()
        {
            StringBuilder sb = new StringBuilder();

            Type typeClass = typeof(StartUp);

            MethodInfo[] methodsInStartUp = typeClass.GetMethods(BindingFlags.Instance|BindingFlags.Static|BindingFlags.Public);
            foreach (var method in methodsInStartUp)
            {

                if (method.CustomAttributes.Any(x=>x.AttributeType==typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attr in attributes)
                    {
                        sb.AppendLine($"{method.Name} is written by {attr.Name}");
                    }

                }

            }

            return sb.ToString().Trim();
        }
    }
}
