using C_Tasks;
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class MainTasks
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Anthonia's Application.");
            Console.WriteLine("We have a range of programs that you can run");
            Console.WriteLine("1. You look older than your age");
            Console.WriteLine("2. Displays an input 4times in a row 1line with spaces between and the other without ");
            Console.WriteLine("3.Displays an input of three columns wide and five rows tall");
            Console.WriteLine("4. To convert celcius degree to kelvin and fahrenheit");
            Console.WriteLine("5. Using the index of a character to remove a specified character ");
            Console.WriteLine("6. To exchange the first and last character of a string input");
            Console.WriteLine("7. To add the first character of a string to the front and back");
            Console.WriteLine("8. Checks between two integers if one is negative and returns True");
            Console.WriteLine("9. Checks two integers if they are the same, finds the sum and returns triple of the sum if they are the same");
            Console.WriteLine("10. Finds the absolute value of two integers (i.e x & y and). If x is greater than y (i.e x > y) it returns double of the absolute value");


            Console.WriteLine("Enter a number between 1 and 10 to go to the corresponding task:");
            _ = int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    TaskOne taskOne = new TaskOne();
                    taskOne.Run();
                    break;
                case 2:
                    TaskTwo taskTwo = new TaskTwo();
                    taskTwo.Run();
                    break;
                case 3:
                    TaskThree taskThree = new TaskThree();
                    taskThree.Run();
                    break;
                case 4:
                    TaskFour taskFour = new TaskFour();
                    taskFour.Run();
                    break;
                case 5:
                    TaskFive taskFive = new TaskFive();
                    taskFive.Run();
                    break;
                case 6:
                    TaskSix taskSix = new TaskSix();
                    taskSix.Run();
                    break;
                case 7:
                    TaskSeven taskSeven = new TaskSeven();
                    taskSeven.Run();
                    break;
                case 8:
                    TaskEight taskEight = new TaskEight();
                    taskEight.Run();
                    break;
                case 9:
                    TaskNine taskNine = new TaskNine();
                    taskNine.Run();
                    break;
                case 10:
                    TaskTen taskTen = new TaskTen();
                    taskTen.Run();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
      
    }
}



