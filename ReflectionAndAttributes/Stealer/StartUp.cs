using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        // 1st part
        public string StealFieldInfo(string investigateClass,params string[] fields)
        {
            Type type = Type.GetType(investigateClass);
            var typeFields = type.GetFields(BindingFlags.NonPublic|BindingFlags.Static|BindingFlags.Public|BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();

            var classInstance = Activator.CreateInstance(type);

            sb.AppendLine($"Class under investigation: {investigateClass}");
            foreach (var field in typeFields)
            {
                if (field.Name=="username" || field.Name=="password")
                {
                    sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
                }
            }

            return sb.ToString().Trim();
        }

        // 2nd part
        public string AnalyzeAccessModifiers()
        {
            Type classType = typeof(Hacker);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var field in classFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classPrivateMethods)
            {
                if (method.Name.StartsWith("get"))
                {
                    sb.AppendLine($"{method.Name} have to be public!");
                }
            }
            foreach (var method in classPublicMethods)
            {
                if (method.Name.StartsWith("set"))
                {
                    sb.AppendLine($"{method.Name} have to be private!");
                }
            }


            return sb.ToString().Trim();
        }

        // 3rd part
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");

            Type typeClass = Type.GetType(className);

            sb.AppendLine($"Base Class: {typeClass.BaseType.Name}");

            MethodInfo[] privateMethods = typeClass.GetMethods(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static);

            foreach (var item in privateMethods)
            {
                sb.AppendLine(item.Name);
            }



            return sb.ToString().Trim();
        }

        // 4th part
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType(className);

            MethodInfo[] allMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var item in allMethods)
            {
                if (item.Name.StartsWith("get"))
                {
                    sb.AppendLine($"{item.Name} will return {item.ReturnType}");
                }
               
            }
            foreach (var item in allMethods)
            {
                if (item.Name.StartsWith("set"))
                {
                    sb.AppendLine($"{item.Name} will return {item.GetParameters().First().ParameterType}");
                }

            }



            return sb.ToString().Trim();
        }
        
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Stealer.Hacker");
            Console.WriteLine(result);

        }
    }
    public class Hacker
    {
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }

}