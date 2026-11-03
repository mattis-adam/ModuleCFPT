using System.Text;

namespace Bibliotheque
{
    // UE02, période 3 : classe à relire avec la grille de revue de code, puis avec la Liste d'erreurs de Visual Studio.
    // Elle fonctionne. Ce n'est pas la question.
    public class RappelEmprunt
    {
        private int _nombreDeRappels;
        private string _derniereAdresse;

        /// <summary>
        /// Prépare le rappel d'un prêt en retard et l'envoie au lecteur.
        /// </summary>
        public string Preparer(Emprunt emprunt, int joursEcoules, string email, string titre, bool urgent)
        {
            int retard = joursEcoules - emprunt.DureeEnJours;
            if (retard < 0)
            {
                retard = 0;
            }

            string message = "Bonjour, le livre " + titre + " a " + retard + " jours de retard.";
            if (retard == 1)
            {
                message = "Bonjour, le livre " + titre + " a " + retard + " jour de retard.";
            }

            Console.WriteLine("Envoi à " + email + " : " + message);

            File.AppendAllText("rappels.log", DateTime.Now + " " + email + Environment.NewLine);

            _nombreDeRappels = _nombreDeRappels + 1;
            return message;
        }
    }
}
