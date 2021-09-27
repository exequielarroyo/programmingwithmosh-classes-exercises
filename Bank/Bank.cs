using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal total = 0;
                foreach (var transaction in transactions)
                {
                    total += transaction.Amount;
                }
                return total;
            }
        }
        public string Number { get; set; }

        private List<Transaction> transactions;
        private static int accountNumberSeed = 320320;

        public Bank(string name, decimal initialBalance)
        {
            Owner = name;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            transactions = new List<Transaction>();
        }

        public void Withdraw(decimal amount, string notes)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException($"Your account balance is {Balance} and cannot withdraw with {amount} amount.");
            }

            if (amount <= 0)
                throw new ArgumentOutOfRangeException("The total withdrawal amount must be greater than 0.");

            var newTransaction = new Transaction(-amount, DateTime.Now, notes);
            transactions.Add(newTransaction);
        }

        public void Deposit(decimal amount, string notes)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("The total deposit amount must be greater than 0");

            var newTransaction = new Transaction(amount, DateTime.Now, notes);
            transactions.Add(newTransaction);
        }
    }
}
