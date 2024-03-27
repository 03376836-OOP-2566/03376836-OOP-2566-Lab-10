// See https://aka.ms/new-console-template for more information
class AAA
{
    public static int b1;

    public void PrintB1()
    {
        Console.WriteLine($"b1 = {b1}");
    }

    public static void PrintB2()
    {
        Console.WriteLine($"b1 = {b1}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a1 = new AAA();
        AAA.PrintB2();
    }
}
