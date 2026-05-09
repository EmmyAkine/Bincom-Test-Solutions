namespace BincomTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("\nEnter a number: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value)) {
                Console.WriteLine(IsOddOrEven(value));
            }
            else {
                Console.WriteLine("Invalid number entered");
            }
        }

        private static string IsOddOrEven(int no) {
            if (no % 2 == 0) {
                return "Number is even";
            }
            else {
                return "Number is odd";
            }
        }
    }

}
