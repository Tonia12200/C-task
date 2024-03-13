using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    internal class TaskFour
    {
        public void Run()
        {

            Console.Write("Enter amount in celcsius: ");
            _ = int.TryParse(Console.ReadLine(), out int c);

            double k, f;
            f = c * (9 / 5) + 32;
            k = c + 273.0;

            Console.WriteLine("Kelvin = " + k);
            Console.WriteLine("Fahrenheit = " + f);
            Console.ReadLine();

        }
    }
}
