using Bibliotheque;

// Programme de démonstration : lancez-le pour voir la classe Emprunt répondre.
// Les tests projetés en classe sont dans le projet Emprunt.Tests (menu Test, Exécuter tous les tests).
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Emprunt emprunt = new Emprunt(14);
        Console.WriteLine($"Durée du prêt : {emprunt.DureeEnJours} jours");
        Console.WriteLine($"Après 5 jours, il reste : {emprunt.DureeRestante(5)}");
        Console.WriteLine($"En retard après 5 jours : {emprunt.EstEnRetard(5)}");
        Console.WriteLine($"Après 20 jours, il reste : {emprunt.DureeRestante(20)}");
        Console.WriteLine($"En retard après 20 jours : {emprunt.EstEnRetard(20)}");

        // UE02
        Console.WriteLine($"Pénalité après 5 jours : CHF {emprunt.Penalite(5):0.00}");
        Console.WriteLine($"Pénalité après 20 jours : CHF {emprunt.Penalite(20):0.00}");
        Console.WriteLine($"Pénalité après 60 jours : CHF {emprunt.Penalite(60):0.00}");

        Emprunt prolonge = emprunt.Prolonger(7);
        Console.WriteLine($"Prêt prolongé de 7 jours : {prolonge.DureeEnJours} jours");

        RappelEmprunt rappel = new RappelEmprunt();
        rappel.Preparer(emprunt, 20, "lecteur@exemple.ch", "L'art du test logiciel", false);
    }
}
