namespace Bank_Account_Management
{
    internal class BankAccount
    {
        private decimal Balance;

        public BankAccount()
        {

        }

        public BankAccount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            Balance = amount;
        }


        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdrawal amount cannot be negative.");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;

        }

        public decimal ViewBalance()
        {
            return Balance;
        }
    }
}