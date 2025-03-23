using System;

namespace Parygmatobj4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Podaj numer konta: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Podaj początkowe saldo: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            BankAccount account = new BankAccount(accountNumber, initialBalance);

            while (true)
            {
                Console.WriteLine("\nWybierz operację:");
                Console.WriteLine("1 - Sprawdź saldo");
                Console.WriteLine("2 - Wpłać środki");
                Console.WriteLine("3 - Wypłać środki");
                Console.WriteLine("4 - Zakończ");
                Console.Write("Twój wybór: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Bieżące saldo: {account.GetBalance():C}");
                        break;
                    case "2":
                        Console.Write("Podaj kwotę wpłaty: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case "3":
                        Console.Write("Podaj kwotę wypłaty: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case "4":
                        Console.WriteLine("Dziękujemy za skorzystanie z banku!");
                        return;
                    default:
                        Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
