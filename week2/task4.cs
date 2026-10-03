using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class ATM
    {
        public double balance=10000;
        public double deposit;
        public double withdraw;
        public int transactioncount = 0;
        public double[] transaction = new double[10];
        public int menu()
        {
            int choice;
            Console.WriteLine("---------------------");
            Console.WriteLine("    ATM STIMULATOR   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("1.Check balance");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.With drawal");
            Console.WriteLine("4.Transaction History");
            Console.WriteLine("5. Exits");
            Console.Write("Enter choice: ");
            choice=int.Parse(Console.ReadLine());
            return choice;
        }
        public void checkBalance()
        {
            Console.WriteLine("Balance is " + balance);
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            if (transactioncount < 10)
            {
                transaction[transactioncount] = amount;
                transactioncount++;
            }
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
            if (transactioncount < 10)
            {
                transaction[transactioncount] = - amount;
                transactioncount++;
            }
        }
        public void Transaction() {
            Console.WriteLine("Transaction History:");

            for (int i = 0; i < transactioncount; i++)
            {
                if (transaction[i] > 0)
                {
                    Console.WriteLine("Deposited: " + transaction[i]);
                }
                else
                {
                    Console.WriteLine("Withdrawn: " + (-transaction[i]));
                }
            }
        }
        static void Main(string[] args)
        {
            ATM person= new ATM();
            int choice;
           
            while (true)
            {

                Console.Clear();
                choice = person.menu();
                if (choice == 1)
                {
                    person.checkBalance();
                }
                else if (choice == 2)
                {
                    person.Deposit(100000);
                }
                else if (choice == 3)
                {
                    person.Withdraw(500000);
                }
                else if (choice == 4)
                {
                    person.Transaction();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("THANKS FOR USING ATM");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
