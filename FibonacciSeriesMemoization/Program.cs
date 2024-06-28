namespace FibonacciSeries
{
    class Program
    {
        static Dictionary<int, int> memo = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the Fibonacci series: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            if (memo.ContainsKey(n))
                return memo[n];

            int result = Fibonacci(n - 1) + Fibonacci(n - 2);
            memo[n] = result;
            return result;
        }
    }
}
