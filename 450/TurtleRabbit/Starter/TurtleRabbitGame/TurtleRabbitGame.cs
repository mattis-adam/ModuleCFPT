namespace TurtleRabbitGame
{
    /// <summary>
    /// La tortue avance d'une case à chaque lancer ; le lapin gagne au premier 6.
    /// </summary>
    public class TurtleRabbitGame
    {
        private Dice _dice;

        public TurtleRabbitGame()
        {
            _dice = new Dice();
        }

        private string _winner = "";
        private int _turtlePosition;

        public string Winner
        {
            get { return _winner; }
        }

        public int TurtlePosition
        {
            get { return _turtlePosition; }
        }

        /// <summary>
        /// Joue une partie et retourne le déroulement, vainqueur en première ligne.
        /// </summary>
        public string Play()
        {
            _turtlePosition = 0;
            string output = "";

            do
            {
                int roll = _dice.RollDice(1, 6);

                if (roll == 6)
                {
                    output += $"Dice: {roll} TurtlePosition: {_turtlePosition}" + Environment.NewLine;
                    output = "Rabbit Wins" + Environment.NewLine + output;
                    _winner = "Rabbit";
                    return output;
                }

                _turtlePosition += 1;
                output += $"Dice: {roll} TurtlePosition: {_turtlePosition}" + Environment.NewLine;

                if (_turtlePosition == 6)
                {
                    _winner = "Turtle";
                    output = "Turtle Wins" + Environment.NewLine + output;
                    return output;
                }
            }
            while (true);
        }
    }
}
