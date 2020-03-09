using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class CalculatorUtility
    {
       static int result = 0;
        public static int CalculatorMethod(int value1, int value2, int Operator)
        {

           switch(Operator)
            {
                case 1:                    
                      result = Addition(value1, value2);                  
                    break;

                case 2:
                    result = Subtraction(value1, value2);
                    break;

                case 3:
                    result = Multiplication(value1, value2);
                    break;

                case 4:
                    result = Division(value1, value2);
                    break;

                default :
                    Console.Write("Oops, you have entered wrong Arithematic symbol");
                    break;  
            }

            return result;
        }


        public static int Addition(int val1, int val2)
        {
            result = val1 + val2;
            return result;
        }

        public static int Subtraction(int val1, int val2)
        {
            result = val1 - val2;
            return result;
        }

        public static int Multiplication(int val1, int val2)
        {
            result = val1 * val2;
            return result;
        }

        public static int Division(int val1, int val2)
        {
            result = val1 % val2;
            return result;
        }
    }
}
