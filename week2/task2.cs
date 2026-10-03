using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
   public class POS
   {
       public String uniqueID;
       public String ProductName;
       public float amount;
       public string date;
       public string time;
       public POS()
       {

       }
       public POS(POS transaction)
       {
           ProductName = transaction.ProductName;
           amount = transaction.amount;
           uniqueID = transaction.uniqueID;
           date = transaction.date;
           time = transaction.time;
       }
       public void display(String label)
       {
           Console.WriteLine(label);
           Console.WriteLine(ProductName);
           Console.WriteLine(uniqueID);
           Console.WriteLine(amount);

       }
       static void Main(string[] args)
       {
           POS transaction1= new POS();
           transaction1.ProductName = "MOUSE";
           transaction1.amount = 7000;
           transaction1.uniqueID = "3A99";
           transaction1.date = "28-SEP-2026";
           transaction1.time = "5:45";
           POS transaction2 = new POS(transaction1);
           Console.WriteLine("-----Before changes-----");
           transaction1.display("Transaction 1:");
           transaction2.display("Transaction 2:");
           transaction2.ProductName = "KEYBOARD";
           transaction2.amount = 10000;
           transaction2.uniqueID = "4B00";
           transaction1.ProductName = "LED";
           Console.WriteLine("-----After changes-----");
           transaction1.display("Transaction 1:");
           transaction2.display("Transaction 2:");
       }
   }
}
