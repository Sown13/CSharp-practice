using cs_practice_1.model;

internal class Program
{
    internal static void Execute<T>() where T : IPractice, new()
    {
        T practice = new T();
        practice.Run();
    }

    private static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    isRunning = false;
                    System.Console.WriteLine("Closing application...");
                    break;
                case 1:
                    Execute<Practcice1>();
                    break;
                case 2:
                    Execute<Practice2>();
                    break;
                case 3:
                    Execute<Practice3>();
                    break;
                case 4:
                    Execute<Practice4>();
                    break;
                case 5:
                    Execute<Practice5>();
                    break;
                case 6:
                    Execute<Practice6>();
                    break;
                case 7:
                    Execute<Practice7>();
                    break;
                default:
                    System.Console.WriteLine("Wrong choice: " + choice + "; please try again");
                    break;
            }
        }
    }
}