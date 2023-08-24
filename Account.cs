using System;
namespace AccountClass
{
    public class AccountClass
    {
        //1. Instance variable: instance of object

        string BankName;
        string AccountName; //name of account
        private double balance;
        

        //2. Constructor:
        public AccountClass(string BankName, string AccountName)
        {
            this.BankName = BankName;
            this.AccountName = AccountName;
            this.balance = 0.0; // initial balance
          
        }

        //Task: Deposite method is greater than zero
        public bool Deposite(double amount)
        {
            if (amount > 0) //deposite can not negative number
            {
                this.balance += amount;
                return true; //deposit successful
            }
            else
            {
                return false;
            }
        }
        //Task: user cannot to withdraw mpore than balance
        public bool Withdraw(double amount)
        {
            if (amount > this.balance) //resolve: when we withdraw if not enough money
            {
                //throw new Exception(message: "Amount is greater than available balance");
                return false;
            }
            //Otherwise:
            this.balance -= amount;
            return true;
        }

        public string PrintAccountInfo()
        {
            return ("\n Bank name: " + this.BankName +
                    "\n Account Name: " + this.AccountName +
                    "\n Balance: " + this.balance); 
        }

       
    }
}