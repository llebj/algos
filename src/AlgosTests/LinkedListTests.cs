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
        Assert.Equal(3, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
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
        Assert.Equal(1, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
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
        Assert.Equal(4, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenAnItemIsAddedToTail_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var linkedList = new Algos.LinkedList<int>();

        // Act
        linkedList.AddToTail(0);

        // Assert
        Assert.Equal("0", string.Join(',', linkedList));
        Assert.Equal(1, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnExistingLinkedList_WhenAnItemIsAddedToTail_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var values = new int[] { 1, 2, 3 };
        var linkedList = new Algos.LinkedList<int>(values);

        // Act
        linkedList.AddToTail(4);

        // Assert
        Assert.Equal("1,2,3,4", string.Join(',', linkedList));
        Assert.Equal(4, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenAnItemIsAddedToHead_ThenASubsequentItemCanBeAddedToTail()
    {
        // Arrange
        var linkedList = new Algos.LinkedList<int>();

        // Act
        linkedList.AddToHead(0);
        linkedList.AddToTail(1);

        // Assert
        Assert.Equal("0,1", string.Join(',', linkedList));
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenAnItemIsAddedToTail_ThenASubsequentItemCanBeAddedToHead()
    {
        // Arrange
        var linkedList = new Algos.LinkedList<int>();

        // Act
        linkedList.AddToTail(0);
        linkedList.AddToHead(1);

        // Assert
        Assert.Equal("1,0", string.Join(',', linkedList));
    }
}
