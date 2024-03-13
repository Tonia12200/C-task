using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    internal class TaskSix
    {
        public void Run()
        {
            Console.WriteLine(first_last("Wresource"));
            Console.WriteLine(first_last("Python"));


        }
        static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
