using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList L = new ArrayList(10);

            for (int i = 0; i < 10; i++)
            {
                string objToList = "obj" + i;

                Console.WriteLine("enqueueing {0}", objToList);

                L.insert(objToList);
            }

            while (!L.isEmpty())
            {
                string objFromList = (string)L.remove();

                Console.WriteLine("dequeue: {0}", objFromList);
            }

        }
    }
}
