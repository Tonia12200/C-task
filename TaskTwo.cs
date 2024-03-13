namespace C_Tasks;

internal class TaskTwo
{
    public void Run()
    {
        Console.Write("Enter a number: ");
        _ = int.TryParse(Console.ReadLine(), out int num);

        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);

        Console.ReadLine();
    }
}
