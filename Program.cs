using System;
using BankState.Models;

namespace BankState
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Open a new account
            var account = new Account("Sühan Akar");

            bool processKill = false;

            while (!processKill)
            {
                Console.Clear();
                Console.WriteLine("Lütfen bir işlem seçin:");
                Console.WriteLine("1. Para Yatırma");
                Console.WriteLine("2. Durum Gösterme");
                Console.WriteLine("3. Para Çekme");
                Console.WriteLine("4. Çıkış");

                string secim = Console.ReadLine();

                Console.WriteLine("Miktar giriniz: ");

                var inputValue = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        account.Deposit(double.Parse(inputValue));
                        break;
                    case "2":
                        account.AccountInfo();
                        break;
                    case "3":
                        account.Withdraw(double.Parse(inputValue));
                        break;
                    case "4":
                        processKill = true;
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim! Tekrar deneyin.");
                        break;
                }

                if (!processKill)
                {
                    Console.WriteLine("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                }
            }
        }
    }
}