using FractionsPourTestUnitaires;

public class FractionTests
{
    [Fact]
    public void Constructeur_SansParametre_DonneUnSurUn()
    {
        // Arrange
        // Act
        Fraction f = new Fraction();

        //Assert
        Assert.Equal(1, f.Numerator);
    }

    [Theory]
    [InlineData(0.2, 1, 2)]
    [InlineData(0.2, 1, 5)]
    public void Constructeur_Double_DonneLaFractionReduite(double d, int numerateur, int denominateur)
    {
        //Arrange, Act 
        Fraction f = new Fraction(d);

        Assert.Equal(numerateur, f.Numerator);
    }
}