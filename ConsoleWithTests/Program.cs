using ConsoleWithTests;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

        Console.Write("a = ");
        string? aVal = Console.ReadLine();
        if (!string.IsNullOrEmpty(aVal))
        {
            a = int.Parse(aVal);
        }


        Console.Write("b = ");
        string? bVal = Console.ReadLine();
        if (!string.IsNullOrEmpty(bVal))
        {
            b = int.Parse(bVal);
        }



        Console.WriteLine("Result = {0}", Calculator.Add(a, b));
    }
}
