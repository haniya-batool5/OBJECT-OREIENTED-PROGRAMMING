using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
   public class Calculator
   {
       public int num1, num2;
       public char op;
       public Calculator() { }
       public Calculator(int n1,int n2,char oper)
       {
           num1= n1;
           num2 = n2;
           op = oper;

       }
       public int calculate() {
           if (op == '+') {
               return num1 + num2;
           }
           else if (op == '-') {
               return num1 - num2;
           }
           else if (op == '*') {
               return num1 * num2;
           }
           else if(op == '/') {
               return num1 / num2;
           }
           else
           {
               return 0;
           }

       }
        
       static void Main(string[] args)
       {
           Calculator a = new Calculator();//with default constructor
           Calculator b= new Calculator(44,5,'-');// with parameterized constructor
           Console.Write("Enter first number: ");
           a.num1 =int.Parse(Console.ReadLine());
           Console.Write("Enter second number: ");
           a.num2 = int.Parse(Console.ReadLine());
           Console.Write("Enter the operator: ");
           a.op=char.Parse(Console.ReadLine());
           int res;
           res=a.calculate();
           Console.WriteLine("Result: "+ res);
           res = b.calculate();
           Console.WriteLine("Result: " + res);
       }
   }
}
