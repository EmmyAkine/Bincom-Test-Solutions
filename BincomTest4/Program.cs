namespace BincomTest4
{
    internal class Program
    {
        private static int[] array = { 2, 4, 6, 8, 10};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int total = 0;
            for (int i = 0; i < array.Length; i++) {
                total += array[i];
            }
            Console.WriteLine("Total is" + " " + total);

            foreach (int num in array) {
                Console.WriteLine(num);
            }
        }
    }
}
