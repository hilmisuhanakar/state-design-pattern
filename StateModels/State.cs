
using System.ComponentModel;
using BankState.Models;

namespace BankState.StateModels
{
    public abstract class State
    {
        public Account Account { get; set; } = null!;
        public double Balance { get; set; } = 0;

        public virtual void Deposit(double amount)
        {
            Console.WriteLine("Para Yatirma Islemi Yapiliyor\n");

            Console.WriteLine($" İşlemden Önceki Durum: {Account.State.GetType().Name}");
            Console.WriteLine($" İşlemden Önceki Bakiye: {Account.Balance}");

            Balance = Balance + amount;
            StateChangeCheck();

            Console.WriteLine($" İşlemden Sonraki Bakiye: {Account.Balance}");
            Console.WriteLine($" İşlemden Sonraki Durum: {Account.State.GetType().Name}\n");
        }
        public virtual void Withdraw(double amount)
        {
            Console.WriteLine("Para Çekme Islemi Yapiliyor\n");


            Console.WriteLine($" İşlemden Önceki Durum: {Account.State.GetType().Name}");
            Console.WriteLine($" İşlemden Önceki Bakiye: {Account.Balance}");

            if ((Balance - amount) < -100)
            {
                Console.WriteLine("Sadece -100 e kadar para çekebilirsiniz.");
            }
            else
            {
                Balance = Balance - amount;
                StateChangeCheck();
            }

            Console.WriteLine($" İşlemden Sonraki Bakiye: {Account.Balance}");
            Console.WriteLine($" İşlemden Sonraki Durum: {Account.State.GetType().Name}\n");
        }
        private void StateChangeCheck()
        {
            if (Balance < 0)
            {
                if (!(Account.State is RedState))
                {
                    Account.State = new RedState(Account, Balance);
                }
            }
            else if (Balance >= 0 && Balance < 1000)
            {
                if (!(Account.State is SilverState))
                {
                    Account.State = new SilverState(Account, Balance);
                }
            }
            else if (Balance >= 1000)
            {
                if (!(Account.State is GoldState))
                {
                    Account.State = new GoldState(Account, Balance);
                }
            }
        }

    }
}