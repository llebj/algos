using Algorithms;

namespace AlgorythmsTests;

public class BubbleSortTests
{
    [Theory]
    [InlineData(new int[] { 1 }, "1")]
    [InlineData(new int[] { 1, 2, 4, 3, 5 }, "1,2,3,4,5")]
    [InlineData(new int[] { 4, 3, 2, 1 }, "1,2,3,4")]
    public void IsSorted(int[] input, string expected)
    {
        // Arrange
        // Act
        BubbleSort.Run(input);

        // Assert
        Assert.Equal(expected, string.Join(',', input));
    }
}
