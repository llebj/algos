using Algorithms;

namespace AlgorythmsTests;

public class LinearSearchTests
{
    [Theory]
    [InlineData(3, true)]
    [InlineData(8, false)]
    public void Found(int needle, bool result)
    {
        // Arrange
        var haystack = new[] { 1, 2, 3, 4, 5 };

        // Act
        var found = LinearSearch.Run(haystack, needle);

        // Assert
        Assert.Equal(result, found);
    }
}