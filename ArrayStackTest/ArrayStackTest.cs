using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackTest
{
    class ArrayStackTest
    {
        static void Main(string[] args)
        {
            ArrayStack mystack = new ArrayStack(5);

            for (int i = 0; i < 5; i++)
            {
                string objToPush = "obj" + i;

                Console.WriteLine("pushing: {0}", objToPush);

                mystack.push(objToPush);
            }

            while (!mystack.isEmpter())
            {
                string objpoped = (string)mystack.pop();

                Console.WriteLine("poping {0}", objpoped);
            }
        }
    }
}
