using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class BankAccount
    {
        private int balance;
        private int accountNumber;

        public BankAccount(int accNum, int initialBalance)
        {
            accountNumber = accNum;
            balance = initialBalance;
        }

        public void Deposit(int amount)
        {
            Console.WriteLine("Enter Your Account Number : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput != accountNumber)
                Console.WriteLine("Invalid Account Number");
            else
            {
                balance += amount;
                Console.WriteLine("Amount Deposited Successfully");
            }
        }

        public void Withdraw(int amount)
        {
            Console.WriteLine("Enter Your Account Number : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput != this.accountNumber)
                Console.WriteLine("Invalid Account Number");
            else
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine("Amount Withdrawn Successfully");
                }
                else
                    Console.WriteLine("Insufficient Balance");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Balance : " + balance);
        }
    }
}