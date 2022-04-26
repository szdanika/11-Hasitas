using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Hasitas
{
    internal class BankAccount
    {
        public BankAccount(string accountNumber, double money)
        {
            AccountNumber = accountNumber;
            Money = money;
        }

        public string AccountNumber { get; private set; }
        public double Money { get; private set; }

        public void Deposit(double amount)
        {
            Money += amount;
        }
        public void Withdraw(double amount)
        {
            Money -= amount;
        }

    }
}
