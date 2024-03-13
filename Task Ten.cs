using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    internal class TaskTen
    {
        public void Run()
        {
            Console.Write("Input a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int av, result;
            av = Math.Abs(x - y);
            result = 2 * av;
            if (x < y)
            {
                Console.WriteLine("Your Absolute Value is " + av);
            }
            else
            {
                Console.WriteLine("Your Absolute Value is " + av);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
