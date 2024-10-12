namespace ConsoleApp1.Exam
{
    // Encapsulation Example
    public class BankAccount
    {
        public decimal Balance { get; }

        public void Deposit(decimal amount)
        {
            //implement logic
        }

        public string Withdraw(decimal amount)
        {
            //implement logic
            return "something";
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
            }
        }
    }

}
