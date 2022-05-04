using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Hasitas
{
    public delegate void KuldesTortent(double money);
    internal class Bank
    {
        private BankHashSet<string, BankAccount> _accounts;
        public Bank(int size, BankHashSet<string, BankAccount>.HashCallBack fg)
        {
            _accounts = new BankHashSet<string,BankAccount>(size, fg);
        }
        public Bank()
        {
            _accounts = new BankHashSet<string, BankAccount>();
        }
        public void Transaction(string from, string to, double amount)
        {
            _accounts.Find(from).Withdraw(amount);
            _accounts.Find(to).Deposit(amount);
            kuldes?.Invoke(_accounts.Find(to).Money);
        }
        public void AccountMoneys()
        {
            List<double> moneys = new List<double>();
        }
        public void RegisterAccount(string AccoutNumber, double deposit)
        {
            BankAccount b = new BankAccount(AccoutNumber, deposit);
            _accounts.Insert(AccoutNumber, b);
        }
        public event KuldesTortent kuldes;
    }
}
