using System;

namespace ConsoleApp1.Exam
{
    // Encapsulation Example
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public decimal Deposit(decimal amount)
        {
            this.Balance = 0;

            if(amount > 0)
            {
                return this.Balance += amount;
            }
            return this.Balance;
        }

        public string Withdraw(decimal amount)
        {

            if (amount > this.Balance)
            {
                return "Insufficient funds.";
            }
            this.Balance -= amount;
            return this.Balance.ToString();
        }

        public string Transfer(BankAccount target, decimal amount)
        {
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
            }
            return this.Balance.ToString();
            

        }
    }

}
