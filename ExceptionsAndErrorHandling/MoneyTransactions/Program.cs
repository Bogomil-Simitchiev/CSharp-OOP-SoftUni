using System;
using System.Collections.Generic;


namespace MyApp
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }

        public double AccountBalance { get; set; }
       

        public BankAccount(int number, double balance)
        {          
            this.AccountNumber = number;
            this.AccountBalance = balance;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            // 1-45.67,2-3256.09,3-97.34


            List<BankAccount> accounts = new List<BankAccount>();

            string[] input = Console.ReadLine().Split(",");

            foreach (string item in input)
            {
                string[] split = item.Split("-");

                BankAccount acc = new BankAccount(int.Parse(split[0]),double.Parse(split[1]));
                accounts.Add(acc);
            }


            while (true)
            {
                
                string[] command = Console.ReadLine().Split(" ");

                string action = command[0];

                if (action=="End")
                {
                    break;
                }

                try
                {
                    if (action != "Withdraw" && action != "Deposit")
                    {
                        throw new Exception("Invalid command!");
                    }
                    else if (action == "Withdraw" || action == "Deposit")
                    {
                        switch (action)
                        {
                            case "Withdraw":

                                int currentNum = int.Parse(command[1]);
                                double sum = double.Parse(command[2]);

                                bool isThere2 = false;

                                foreach (BankAccount account in accounts)
                                {
                                    if (account.AccountNumber == currentNum)
                                    {
                                        isThere2 = true;
                                        if (account.AccountBalance > sum)
                                        {

                                            account.AccountBalance -= sum;
                                            Console.WriteLine($"Account {account.AccountNumber} has new balance: {account.AccountBalance:f2}");
                                            Console.WriteLine("Enter another command");
                                        }
                                        else
                                        {
                                            throw new Exception("Insufficient balance!");
                                        }
                                    }
                                }
                                if (isThere2 == false)
                                {
                                    throw new Exception("Invalid account!");
                                }


                                break;
                            case "Deposit":
                                int currentNumAcc = int.Parse(command[1]);
                                double sum2 = double.Parse(command[2]);

                                bool isThere = false;

                                foreach (BankAccount account in accounts)
                                {
                                    if (account.AccountNumber == currentNumAcc)
                                    {
                                        isThere = true;
                                        account.AccountBalance += sum2;
                                        Console.WriteLine($"Account {account.AccountNumber} has new balance: {account.AccountBalance:f2}");
                                        Console.WriteLine("Enter another command");
                                    }
                                }
                                if (isThere == false)
                                {
                                    throw new Exception("Invalid account!");
                                }
                                break;
                        }


                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter another command");
                }
                
                
                
            }


        }
    }
}