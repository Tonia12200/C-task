namespace C_Tasks;

 class TaskOne
{
    public void Run()
    {
        Console.Write("Enter your age: ");
        _ = int.TryParse(Console.ReadLine(), out int age);
        //int age = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("You look Older than " + age);
        Console.ReadLine();
    }
}
