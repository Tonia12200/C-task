using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    internal class TaskSeven
    {
        public void Run()
        {
            Console.Write("Enter a word or sentence");
            string word = Console.ReadLine();
            Console.WriteLine(word[0] + word + "." + word[0]);
        }
    }
}
