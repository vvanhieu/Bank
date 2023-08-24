using System;
using System.Security.Principal;

namespace AccountClass
{ 

    
    public class TestAccount
    {
        public enum AccoutOption
        {
            Deposit = 1,
            Withdraw,
            Print,
            Quit
        }

        static void Main(string[] args)
        {

            AccountClass account = new AccountClass("Commbank", "Van Hieu Nguyen");
            Console.WriteLine(account.PrintAccountInfo());

            bool continueLoop = true; //do while condition
            do
            {
                Console.WriteLine();
                Console.WriteLine("How can I help you today?");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Print Information");
                Console.WriteLine("4. Quit");
                Console.Write("Enter your option: ");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    // Parse user's choice into AccountBank enum
                    AccoutOption choose = (AccoutOption)option;

                    switch (choose)
                    {
                        case AccoutOption.Deposit:
                            DoDeposit(account);
                            break;

                        case AccoutOption.Withdraw:
                            DoWithdraw(account);
                            break;

                        case AccoutOption.Print:
                            DoPrint(account);
                            break;
                        case AccoutOption.Quit:
                            Console.WriteLine("Existing the program.");
                            continueLoop = false; // Set the condition to exit the loop
                            break;
                        default:
                            throw new Exception("Invalid choice. Please choose a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter another option using number.");
                }

            } while (continueLoop); // Infinite loop until user chooses to exit
        }

        public static void DoDeposit(AccountClass account)
        {
            Console.Write(" Amount to deposit into your bank account: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            bool successDeposit = account.Deposite(amount);
            if (successDeposit)
            {
                Console.WriteLine($" Deposit of {amount} was successful.");
            }
            else
            {
                Console.WriteLine(" Deposit failed. Please try again.");
            }
        }
        public static void DoWithdraw(AccountClass account)
        {
            Console.Write(" Amount to withdraw into your bank account: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            bool withdrawSuccess = account.Withdraw(amount);
            if (withdrawSuccess)
            {
                Console.WriteLine($" Withdraw of {amount} was successful.");
            }
            else
            {
                Console.WriteLine(" Withdraw failed. Please try again.");
            }
        }
        public static void DoPrint(AccountClass account)
        {
            Console.WriteLine(account.PrintAccountInfo());
        }

    }
}



