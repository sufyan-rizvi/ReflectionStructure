using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionStructure.Models
{
    internal class Account
    {
        

        const double MIN_BALANCE = 500;
        public Account(int id, string name, double balance)
        {
            AccountNumber = id;
            Name = name;
            if (balance < MIN_BALANCE)
                Balance = MIN_BALANCE;
            else
                Balance = balance;
        }

        public Account(int id, string name)
        {
            AccountNumber = id;
            Name = name;
            Balance = MIN_BALANCE;

        }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public static Account CreateAccount(int id, string name, double balance = MIN_BALANCE)
        {
            return new Account(id, name, balance);
        }
        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                $"Account Name: {Name}\n" +
                $"Account Balance: {Balance}\n";
        }
    }
}
