using System.Diagnostics;
using System.Runtime.CompilerServices;
using BankState.Models;

namespace BankState.StateModels
{
    public class RedState : State
    {
        public RedState(Account account, double balance)
        {
            Balance = balance;
            Account = account;
        }
    }
}