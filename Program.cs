using System;

namespace console_bank_cs
{

    public class Client
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name { get; set; }
        public string DateJoined { get; set; }
    }

    public class BankAccount
    {
        public string Client { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }

        public void CheckBalance()
        {
            Console.WriteLine("Your current balance is " + this.Balance);
        }

        public void Withdraw(int amount)
        {
            this.Balance -= amount;
            if (this.Balance > 0)
            {
                Console.WriteLine("Your new balance is " + this.Balance);
            }
            else
            {
                Console.WriteLine("You cannot withdraw that amount, balance not allowed to be negative!");
            }
        }

        public void Deposit(int amount)
        {
            this.Balance += amount;
            Console.WriteLine("Your new balance is " + this.Balance);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Hi, what is your name?");
            client.Name = Console.ReadLine();
            Console.WriteLine("Welcome, " + client.Name);

            BankAccount bankAccount = new BankAccount();
            bankAccount.Balance = 10000;
            bankAccount.CheckBalance();

            Console.WriteLine("What would you like to do (withdraw/deposit)?");
            bankAccount.Type = Console.ReadLine();

            if (bankAccount.Type == "withdraw")
            {
                Console.WriteLine("How much do you want to withdraw?");
                string amount = Console.ReadLine();
                int amountValue = Int32.Parse(amount);
                bankAccount.Withdraw(amountValue);
            }
            else if (bankAccount.Type == "deposit")
            {
                Console.WriteLine("How much do you want to deposit?");
                string amount = Console.ReadLine();
                int amountValue = Int32.Parse(amount);
                bankAccount.Deposit(amountValue);
            }
            else
            {
                Console.WriteLine("Please specify withdraw or deposit!");
            }
        }
    }
}
