using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    class TaskEight
    {
        public void Run()
        {
            Console.Write("Input a number: ");
            _ = int.TryParse(Console.ReadLine(), out int x);
            Console.Write("Input a number: ");
            _ = int.TryParse(Console.ReadLine(), out int y);
            if (x < 0 && y > 0 || x > 0 && y < 0)
            {
                Console.WriteLine("True");
            }


        }
    }
}
