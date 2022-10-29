using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{

    public class Spy
    {
       


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
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAccessModifiers();
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