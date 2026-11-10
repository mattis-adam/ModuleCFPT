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

    [Fact]
    public void Constructeur_DenominateurZero_LeveDivideByZeroException()
    {
        // Arrange, Act, Assert
        Assert.Throws<DivideByZeroException>(() => new Fraction(1, 0));
    }

    [Fact]
    public void Constructeur_AvecDeuxEtQuatre_DonneUnSurDeux()
    {
        Fraction f = new Fraction(2, 4);

        Assert.Equal("1/2", f.ToString());
    }

    [Theory]
    [InlineData(1, 2, 1, 2, 1, 2)]
    [InlineData(1, 4, 1, 4, 1, 2)]
    [InlineData(1, 2, 1, 3, 5, 6)]
    public void Add_AvecFractionsValide_DonneFractionsPrevue(int num, int denom, int num1, int denom1, int numExcepted, int denumExcepted)
    {
        //arrange 
        var fraction1 = new Fraction(num, denom);
        var fraction2 = new Fraction(num1, denom1);

        //Act
        var resultFraction = fraction1.Add(fraction2);

        Assert.Equal($"{numExcepted}/{denumExcepted}", resultFraction.ToString());
    }
}