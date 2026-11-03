namespace Bibliotheque
{
    // Code des démonstrations des UE01 et UE02, domaine voisin du fil rouge : une bibliothèque de prêt.
    // Convention de l'école : champ privé et propriété explicite, jamais de propriété automatique.
    public class Emprunt
    {
        // Tarif de la pénalité de retard, par jour, en francs.
        public const decimal TarifParJour = 0.50m;

        // Plafond de la pénalité, en francs.
        public const decimal PenaliteMaximale = 10.00m;

        private int _dureeEnJours;

        public int DureeEnJours
        {
            get { return _dureeEnJours; }
        }

        public Emprunt(int dureeEnJours)
        {
            // UE02 : le refus se teste avec Assert.Throws.
            if (dureeEnJours <= 0)
            {
                throw new ArgumentException("La durée doit être positive.", nameof(dureeEnJours));
            }
            _dureeEnJours = dureeEnJours;
        }

        /// <summary>
        /// Retourne le nombre de jours restants, négatif quand le prêt est dépassé.
        /// </summary>
        public int DureeRestante(int joursEcoules)
        {
            return _dureeEnJours - joursEcoules;
        }

        public bool EstEnRetard(int joursEcoules)
        {
            return DureeRestante(joursEcoules) < 0;
        }

        /// <summary>
        /// Retourne la pénalité due : TarifParJour par jour de retard, plafonnée à PenaliteMaximale.
        /// Zéro tant que le prêt n'est pas dépassé.
        /// </summary>
        public decimal Penalite(int joursEcoules)
        {
            int retard = DureeRestante(joursEcoules);
            if (retard <= 0)
            {
                return 0m;
            }
            decimal montant = retard * TarifParJour;
            return Math.Min(montant, PenaliteMaximale);
        }

        /// <summary>
        /// Retourne un nouveau prêt, prolongé de joursSupplementaires.
        /// </summary>
        public Emprunt Prolonger(int joursSupplementaires)
        {
            return new Emprunt(_dureeEnJours + joursSupplementaires);
        }
    }
}
