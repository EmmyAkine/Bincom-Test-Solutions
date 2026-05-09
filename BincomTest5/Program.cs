namespace BincomTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet("Alice");

        }

        private static void Greet(string name) {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
