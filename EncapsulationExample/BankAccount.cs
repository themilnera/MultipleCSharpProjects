using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EncapsulationExample
{
    public class BankAccount
    {
        private int balance;
        public BankAccount(int balance)
        {
            this.balance = balance;
        }
        internal void Deposit(int amount)
        {
            balance += amount;
        }
        internal void Withdraw(int amount)
        {
            balance -= amount;
        }
        internal int getBalance()
        {
            return balance;
        }
    }
}
