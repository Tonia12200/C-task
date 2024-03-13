using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
     class TaskNine
    {
        public void Run()
        {
            Console.Write("Input a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int v, result;
            v = x + y;
            result = 3 * v;
            if (x != y)
            {
                Console.WriteLine("Your Value is " + v);
            }
            else
            {
                Console.WriteLine("Your  Value is " + v);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
