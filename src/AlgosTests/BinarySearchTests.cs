using Algos;

namespace AlgosTests;

public class BinarySearchTests
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(8, false)]
    [InlineData(0, false)]
    public void Found(int needle, bool expected)
    {
        // Arrange
        var heystack = new int[] { 1, 2, 3, 4, 5 };

        // Act
        var found = BinarySearch.Run(heystack, needle);

        // Assert
        Assert.Equal(expected, found);
    }
}
