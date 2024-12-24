using BankState.StateModels;

namespace BankState.Models
{
    public class Account
    {
        public State State { get; set; }
        private readonly string Name;

        public Account(string name)
        {
            this.Name = name;
            this.State = new SilverState(this, 0);
        }

        public double Balance
        {
            get { return State.Balance; }
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
        }
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
        }

        public void AccountInfo()
        {
            Console.WriteLine($"Isim = {this.Name}");
            Console.WriteLine($"Bakiye = {this.Balance}");
            Console.WriteLine($"Durumu = {this.State.GetType().Name}");
        }


    }
}