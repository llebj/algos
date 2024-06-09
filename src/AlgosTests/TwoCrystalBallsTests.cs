using Algos;

namespace AlgosTests;

public class TwoCrystalBallsTests
{
    [Fact]
    public void Breaks()
    {
        // Arrange
        var breaks = new bool[] { false, false, false, false, true };

        // Act
        var result = TwoCrystalBalls.Run(breaks);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void DoesNotBreak()
    {
        // Arrange
        var breaks = new bool[] { false, false, false, false, false };

        // Act
        var result = TwoCrystalBalls.Run(breaks);

        // Assert
        Assert.Equal(-1, result);
    }
}
