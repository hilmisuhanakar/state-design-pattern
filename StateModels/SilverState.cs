using System.ComponentModel;
using BankState.Models;

namespace BankState.StateModels
{
    public class SilverState : State
    {
        public SilverState(State state) :
        this(state.Account, state.Balance)
        {
        }
        public SilverState(Account account, double balance)
        {
            Balance = balance;
            Account = account;
        }
    }
}