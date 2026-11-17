namespace TurtleRabbitGame
{
    /// <summary>
    /// Un dé réel : le résultat est aléatoire.
    /// </summary>
    public class Dice : IDice
    {
        private Random _rnd;

        public Dice()
        {
            _rnd = new Random();
        }

        /// <summary>
        /// Retourne un entier entre min et max compris.
        /// </summary>
        public int RollDice(int min, int max)
        {
            return _rnd.Next(min, max + 1);
        }
    }
}
