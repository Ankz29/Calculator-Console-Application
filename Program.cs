using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorConsole;
namespace CalculatorConsole
{
    class Program
    {
        public static int variable_A;
        public static int variable_B;
        public static int Operator;
        static void Main(string[] args)
        {
            Console.Write("enter 1 for addition: "+"\n"); 
            Console.Write("enter 2 for subtraction: "+"\n");
            Console.Write("enter 3 for multiplication: "+"\n");
            Console.Write("enter 4 for divison: "+"\n");

            Operator = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter 1st value: ");
            variable_A = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter 2nd value: ");
            variable_B = Convert.ToInt32(Console.ReadLine());

           var data =  CalculatorUtility.CalculatorMethod(variable_A, variable_B, Operator);

            Console.Write("The resultant is {0}", data);

            Console.ReadLine();
        }
    }
}
