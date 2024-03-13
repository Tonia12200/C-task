using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    internal class TaskThree
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            _ = int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);
        }
    }
}
