namespace SuiteFibonacci_TDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fb = new Fibonacci();
            for (int i = 0; i <= 16; i++)
            {
                Console.WriteLine($"F({i}) = " + fb.GetValue(i));
            }
        }
    }
}
