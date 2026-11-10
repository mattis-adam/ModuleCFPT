using SuiteFibonacci_TDD;
using Xunit;

public class FibonacciTests
{
    [Fact]
    public void GetValue_Zero_RetourneZero()
    {
        // Arrange
        Fibonacci fb = new Fibonacci();
        int resultatAttendu = 0;

        // Act
        int resultatObtenu = fb.GetValue(0);

        // Assert
        Assert.Equal(resultatAttendu, resultatObtenu);
    }

 //Décommentez ce test quand le précédent est vert
 
    [Fact]
    public void GetValue_Un_RetourneUn()
    {
        // Arrange
        Fibonacci fb = new Fibonacci();
        int resultatAttendu = 1;

        // Act
        int resultatObtenu = fb.GetValue(1);

        // Assert
        Assert.Equal(resultatAttendu, resultatObtenu);
    }


    //Décommentez ce test quand le précédent est vert

    [Fact]
    public void GetValue_Deux_RetourneUn()
    {
        // Arrange
        Fibonacci fb = new Fibonacci();
        int resultatAttendu = 1;

        // Act
        int resultatObtenu = fb.GetValue(2);

        // Assert
        Assert.Equal(resultatAttendu, resultatObtenu);
    }


    /* Décommentez ce test quand le précédent est vert

        [Fact]
        public void GetValue_Trois_RetourneDeux()
        {
            // Arrange
            Fibonacci fb = new Fibonacci();
            int resultatAttendu = 2;

            // Act
            int resultatObtenu = fb.GetValue(3);

            // Assert
            Assert.Equal(resultatAttendu, resultatObtenu);
        }
        */

    /* Décommentez ce test quand le précédent est vert

        [Theory]
        [InlineData(6, 8)]
        [InlineData(10, 55)]
        [InlineData(12, 144)]
        [InlineData(15, 610)]
        public void GetValue_NombreQuelconque_RetourneLaSommeDesDeuxPrecedents(int number, int result)
        {
            // Arrange
            Fibonacci fb = new Fibonacci();

            // Act
            int resultatObtenu = fb.GetValue(number);

            // Assert
            Assert.Equal(result, resultatObtenu);
        }
        */
}
