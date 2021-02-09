using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueueTest
{
    class ArrayQueueTest
    {
        static void Main(string[] args)
        {
            /*ArrayQueue myqueue = new ArrayQueue(10);

            for (int i = 0; i < 10; i++)
            {
                string objToQueue = "obj" + i;

                Console.WriteLine("enqueueing {0}", objToQueue);

                myqueue.enqueue(objToQueue);
            }

            while (!myqueue.isEmpty())
            {
                string objFromQueue = (string)myqueue.dequeue();

                Console.WriteLine("dequeue: {0}", objFromQueue);
            }*/

            ArrayQueue myqueue = new ArrayQueue(5);

            for (int i = 0; i < 5; i++)
            {
                string objToQueue = "" + i;

                Console.Write("Enter your code:");
                objToQueue = Console.ReadLine();

                myqueue.enqueue(objToQueue);
            }

            while (!myqueue.isEmpty())
            {
                string objFromQueue = (string)myqueue.dequeue();

                Console.WriteLine("Information of the student is {0}", objFromQueue);
            }
        }
    }
}
