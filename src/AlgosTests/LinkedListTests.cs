namespace AlgosTests;

public class LinkedListTests
{
    [Fact]
    public void GivenAnArrayOfIntegers_WhenALinkedListIsConstructed_ThenConstructALinkedListWithTheCorrectValues()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };

        // Act
        var linkedList = new Algos.LinkedList<int>(input);

        // Assert
        Assert.Equal("1,2,3", string.Join(',', linkedList));
    }
}
