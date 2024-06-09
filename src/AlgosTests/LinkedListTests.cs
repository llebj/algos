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

    [Fact]
    public void GivenAnEmptyLinkedList_WhenAnItemIsAddedToHead_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var linkedList = new Algos.LinkedList<int>();

        // Act
        linkedList.AddToHead(0);

        // Assert
        Assert.Equal("0", string.Join(',', linkedList));
    }

    [Fact]
    public void GivenAnExistingLinkedList_WhenAnItemIsAddedToHead_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };
        var linkedList = new Algos.LinkedList<int>(input);

        // Act
        linkedList.AddToHead(0);

        // Assert
        Assert.Equal("0,1,2,3", string.Join(',', linkedList));
    }
}
