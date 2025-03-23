using System;


namespace Parygmatobj4
{
    class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Wpłacono: {amount:C}. Nowe saldo: {balance:C}");
            }
            else
            {
                Console.WriteLine("Kwota wpłaty musi być większa niż 0.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Wypłacono: {amount:C}. Pozostałe saldo: {balance:C}");
            }
            else
            {
                Console.WriteLine("Niewystarczające środki lub błędna kwota wypłaty.");
            }
        }
    }

}
