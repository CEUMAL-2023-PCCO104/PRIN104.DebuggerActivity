namespace PRIN104.DebuggerActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expected fibbonacci values 0, 1, 1, 2, 3, 5, 8, 13, 21...
            // Get the 5th element of fibbonacci values.

            int result = Fibonacci(5);

            Console.WriteLine($"Actual Fibonacci[5] = {result}");
        }

        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            Console.WriteLine($"Fibonacci[0] = {n1}");
            Console.WriteLine($"Fibonacci[1] = {n2}");

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;

                Console.WriteLine($"Fibonacci[{i}] = {sum}");
            }

            Console.WriteLine();

            return n == 0 ? n1 : n2;
        }
    }
}
