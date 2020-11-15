using System;

namespace Fig413
{
    class Account
    {
        public String Name { get; set; }
        private decimal balance;

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }

        public decimal Balance
        {
            get => balance;
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
                else
                {
                    balance = 0.0m;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance += depositAmount;
            }
        }
    }
}