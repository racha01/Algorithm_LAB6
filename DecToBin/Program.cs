using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int value, sum, sum1;
            Console.Write("Enter cost:");
            value = int.Parse(Console.ReadLine());
            int Ans = value * 2;
            ArrayStack mystack = new ArrayStack(value);

            int i = 0;
            while (true)
            {
                i++;
                if (Ans > 1)
                {
                    sum = Ans / 2;
                    sum1 = sum % 2;
                    Ans = sum;
                    string objToPush = "" + sum1;
                    mystack.push(objToPush);
                }
                else if (Ans == 1)
                    break;
            }
            Console.Write("The resulting binary number is ");
            while (!mystack.isEmpter())
            {
                string objpoped = (string)mystack.pop();
                Console.Write(objpoped);
            }
            Console.WriteLine();
        }
    }
}
