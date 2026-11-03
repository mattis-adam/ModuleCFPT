using Bibliotheque;
using Xunit;

// Tests projetés en classe pendant l'UE01 et l'UE02
public class EmpruntTests
{
    // ------------------------------------------------------------ UE01, rappel

    // Un test xUnit, les trois temps
    // Le message d'un test rouge : remplacer 9 par 10 pour montrer "Values differ".
    /// <summary>
    /// Given : Un prêt de 14 jours
    /// When  : Durée restante après 5 jours
    /// Then  : Reste 9 jours
    /// </summary>
    [Fact]
    public void DureeRestante_PretDeQuatorzeJoursApresCinqJours_ResteNeufJours()
    {
        // Arrange
        Emprunt emprunt = new Emprunt(dureeEnJours: 14);

        // Act
        int restant = emprunt.DureeRestante(joursEcoules: 5);

        // Assert : 14 - 5
        Assert.Equal(9, restant);
    }

    // Un booléen : Assert.False, pas Assert.Equal(false, ...)
    /// <summary>
    /// Given : Un prêt de 14 jours
    /// When  : Cinq jours se sont écoulés
    /// Then  : N'est pas en retard (faux)
    /// </summary>
    [Fact]
    public void EstEnRetard_CinqJoursApresUnPretDeQuatorze_EstFaux()
    {
        // Arrange
        Emprunt emprunt = new Emprunt(dureeEnJours: 14);

        // Act
        bool enRetard = emprunt.EstEnRetard(joursEcoules: 5);

        // Assert
        Assert.False(enRetard);
    }

    // ------------------------------------------------------------ UE02, une série de valeurs

    // [Theory] remplace [Fact] : une ligne [InlineData] par jeu de valeurs, dans l'ordre des paramètres.
    // Dans l'Explorateur de tests, trois lignes sous le même nom.
    /// <summary>
    /// Given : Un prêt de n jours
    /// When  : Durée restante après m jours
    /// Then  : Reste n - m jours, négatif quand le prêt est dépassé
    /// </summary>
    [Theory]
    [InlineData(14, 5, 9)]
    [InlineData(14, 14, 0)]
    [InlineData(14, 20, -6)]
    public void DureeRestante_JoursEcoules_RetourneLaDifference(int duree, int joursEcoules, int attendu)
    {
        // Arrange
        Emprunt emprunt = new Emprunt(duree);

        // Act
        int restant = emprunt.DureeRestante(joursEcoules);

        // Assert
        Assert.Equal(attendu, restant);
    }

    // ------------------------------------------------------------ UE02, une exception

    // Assert.Throws<T>(() => ...) : le code à exécuter est dans la lambda, xUnit l'appelle et attend l'exception.
    /// <summary>
    /// Given : Rien
    /// When  : Créer un prêt de 0 jour
    /// Then  : ArgumentException
    /// </summary>
    [Fact]
    public void Constructeur_DureeZero_LeveArgumentException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentException>(() => new Emprunt(0));
    }

    // Assert.Throws retourne l'exception : on peut vérifier le paramètre en cause.
    /// <summary>
    /// Given : Rien
    /// When  : Créer un prêt de -3 jours
    /// Then  : ArgumentException sur le paramètre dureeEnJours
    /// </summary>
    [Fact]
    public void Constructeur_DureeNegative_LeveArgumentExceptionSurDureeEnJours()
    {
        // Arrange, Act
        ArgumentException exception = Assert.Throws<ArgumentException>(() => new Emprunt(-3));

        // Assert
        Assert.Equal("dureeEnJours", exception.ParamName);
    }

    // L'exception part-elle de la méthode testée ? Lire le message rouge si le test l'est, et la pile des appels.
    /// <summary>
    /// Given : Un prêt de 14 jours
    /// When  : Le prolonger de -20 jours
    /// Then  : ArgumentException
    /// </summary>
    [Fact]
    public void Prolonger_MoinsVingtJours_LeveArgumentException()
    {
        // Arrange
        Emprunt emprunt = new Emprunt(14);

        // Act, Assert
        Assert.Throws<ArgumentException>(() => emprunt.Prolonger(-20));
    }

    // ------------------------------------------------------------ UE02, déboguer un test rouge

    // Ces lignes sont rouges : c'est voulu, c'est la démonstration du débogueur.
    // Point d'arrêt (F9) dans Penalite, clic droit sur le test, Déboguer, espion sur retard.
    // La correction se fait en classe, dans Emprunt.Penalite.
    /// <summary>
    /// Given : Un prêt de 14 jours
    /// When  : Pénalité après m jours
    /// Then  : CHF 0.50 par jour de retard, zéro sans retard, au plus CHF 10.00
    /// </summary>
    [Theory]
    [InlineData(5, 0.00)]
    [InlineData(20, 3.00)]
    [InlineData(60, 10.00)]
    public void Penalite_JoursEcoules_RetourneLeMontantPlafonne(int joursEcoules, decimal attendu)
    {
        // Arrange
        Emprunt emprunt = new Emprunt(14);

        // Act
        decimal montant = emprunt.Penalite(joursEcoules);

        // Assert
        Assert.Equal(attendu, montant);
    }
}
