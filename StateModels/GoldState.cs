using BankState.Models;

namespace BankState.StateModels
{
    public class GoldState : State
    {
        public GoldState(Account account, double balance)
        {
            Balance = balance;
            Account = account;
        }
    }
}