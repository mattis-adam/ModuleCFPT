namespace TurtleRabbitGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TurtleRabbitGame game = new TurtleRabbitGame();

            Console.WriteLine(game.Play());

            Console.ReadKey();
        }
    }
}
