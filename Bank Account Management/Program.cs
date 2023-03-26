namespace Bank_Account_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("==================================================================================");
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Bank Account Management System!");
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. View account balance");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter your initial deposit amount: ");
                            decimal initialDeposit = decimal.Parse(Console.ReadLine());
                            account = new BankAccount(initialDeposit);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Account created successfully!!!");
                            Console.ResetColor();
                            break;
                        case 2:
                            if (account == null)
                            {
                                throw new Exception("No account found.");
                            }
                            else
                            {
                                Console.Write("Enter the deposit amount: ");
                                decimal depositAmount = decimal.Parse(Console.ReadLine());
                                account.Deposit(depositAmount);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Transaction completed successfully!!!");
                                Console.ResetColor();
                            }
                            break;
                        case 3:
                            if (account == null)
                            {
                                throw new Exception("No account found.");
                            }
                            else
                            {
                                Console.Write("Enter the withdrawal amount: ");
                                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                                account.Withdraw(withdrawalAmount);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Transaction completed successfully!!!");
                                Console.ResetColor();

                            }
                            break;
                        case 4:
                            if (account == null)
                            {
                                throw new Exception("No account found.");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write("Your current account balance is: ");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(account.ViewBalance() + "Rwf");
                                Console.ResetColor();
                            }
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bye. Thanks for banking with us!!!");
                            Console.ResetColor();
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Invalid choice.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + e.Message);
                    Console.ResetColor();
                }


            }
        }
    }
}