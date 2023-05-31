class Program
{
    private static void PrintHelloWorldUpperWithVariable()
    {
        string output = "hello world!";
        Console.WriteLine(output.ToUpper());
    }

    private static void ParameterMethod(string text)
    {
        Console.WriteLine(text);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        PrintHelloWorldUpperWithVariable();
        ParameterMethod("hello world!");
    }
}
