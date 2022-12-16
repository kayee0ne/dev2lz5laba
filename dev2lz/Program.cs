namespace Dev
{
    class Dev
    {
        static void Main()
        {
            Console.WriteLine("1 for +");
            Console.WriteLine("2 for -");
            Console.WriteLine("3 for *");
            Console.WriteLine("4 for /");
            var line = Console.ReadLine();
            Console.WriteLine("insert symbols for operation");
            var op = Console.ReadLine();

            Console.WriteLine(logic.run(line, op));
        }
    }
}