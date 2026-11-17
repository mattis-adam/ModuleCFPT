using TurtleRabbitGame;
using TRG = TurtleRabbitGame.TurtleRabbitGame;
using Xunit;

public class TurtleRabbitGameTests
{
    public int DiceStub4()
    {
        return 4;
    }
    public int DiceStub6()
    {
        return 6;
    }

    [Fact]
    public void Play_DeToujoursSix_LapinGagne()
    {
        // Arrange
        TRG game = new TRG();
        // Act

        game.Play();
        // Assert

    }

    [Fact]
    public void Play_DeToujoursQuatre_TortueGagne()
    {
        // Arrange

        // Act

        // Assert

    }
}
