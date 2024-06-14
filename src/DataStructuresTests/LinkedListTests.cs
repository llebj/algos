namespace DataStructuresTests;

public class LinkedListTests
{
    [Fact]
    public void WhenANewLinkedListIsConstructed_ThenTheLinkedListIsEmpty()
    {
        // Arrange
        // Act
        var linkedList = new DataStructures.LinkedList<int>();

        // Assert
        Assert.True(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnArrayOfIntegers_WhenALinkedListIsConstructed_ThenConstructALinkedListWithTheCorrectValues()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };

        // Act
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Assert
        Assert.Equal("1,2,3", string.Join(',', linkedList));
        Assert.Equal(3, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    // Add to head and tail tests.
    [Fact]
    public void GivenAnEmptyLinkedList_WhenAnItemIsAddedToHead_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var linkedList = new DataStructures.LinkedList<int>();

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
        var linkedList = new DataStructures.LinkedList<int>(input);

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
        var linkedList = new DataStructures.LinkedList<int>();

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
        var linkedList = new DataStructures.LinkedList<int>(values);

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
        var linkedList = new DataStructures.LinkedList<int>();

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
        var linkedList = new DataStructures.LinkedList<int>();

        // Act
        linkedList.AddToTail(0);
        linkedList.AddToHead(1);

        // Assert
        Assert.Equal("1,0", string.Join(',', linkedList));
    }

    // Remove from head and tail tests.
    [Fact]
    public void GivenAnExistingLinkedList_WhenAnItemIsRemovedFromHead_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        linkedList.RemoveFromHead();

        // Assert
        Assert.Equal("2,3", string.Join(',', linkedList));
        Assert.Equal(2, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnExistingLinkedList_WhenAnItemIsRemovedFromTail_ThenCorrectlyUpdateTheLinkedList()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        linkedList.RemoveFromTail();

        // Assert
        Assert.Equal("1,2", string.Join(',', linkedList));
        Assert.Equal(2, linkedList.Count);
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenALinkedListWithOneItem_WhenTheLastItemIsRemovedFromHead_ThenTheLinkedListIsEmpty()
    {
        // Arrange
        var input = new int[] { 1 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        linkedList.RemoveFromHead();

        // Assert
        Assert.True(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenALinkedListWithOneItem_WhenTheLastItemIsRemovedFromTail_ThenTheLinkedListIsEmpty()
    {
        // Arrange
        var input = new int[] { 1 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        linkedList.RemoveFromTail();

        // Assert
        Assert.True(linkedList.IsEmpty);
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenRemoveFromHeadIsCalled_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var linkedList = new DataStructures.LinkedList<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(linkedList.RemoveFromHead);
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenRemoveFromTailIsCalled_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var linkedList = new DataStructures.LinkedList<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(linkedList.RemoveFromTail);
    }

    // Get head and tail tests.
    [Fact]
    public void GivenAnEmptyLinkedList_WhenCallingGetHead_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var linkedList = new DataStructures.LinkedList<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedList.GetHead());
    }

    [Fact]
    public void GivenAnEmptyLinkedList_WhenCallingGetTail_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var linkedList = new DataStructures.LinkedList<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedList.GetTail());
    }

    [Fact]
    public void GivenAnExistingLinkedList_WhenCallingGetHead_ThenReturnTheCorrectValue()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        var result = linkedList.GetHead();

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void GivenAnExistingLinkedList_WhenCallingGetTail_ThenReturnTheCorrectValue()
    {
        // Arrange
        var input = new int[] { 1, 2, 3 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        var result = linkedList.GetTail();

        // Assert
        Assert.Equal(3, result);
    }

    // Reverse list tests.
    [Fact]
    public void GivenAnExistingLinkedList_WhenReverseIsCalled_ThenCorrectlyReverseTheLinkedList()
    {
        // Arrange
        var input = new int[] { 1, 2, 3, 4 };
        var linkedList = new DataStructures.LinkedList<int>(input);

        // Act
        linkedList.Reverse();

        // Assert
        Assert.Equal("4,3,2,1", string.Join(',', linkedList));
    }

    [Fact]
    public void GivenAReversedLinkedList_WhenGetHeadIsCalled_ThenReturnTheCorrectValue()
    {
        // Arrange
        var input = new int[] { 1, 2, 3, 4 };
        var linkedList = new DataStructures.LinkedList<int>(input);
        linkedList.Reverse();

        // Act
        var result = linkedList.GetHead();

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void GivenAReversedLinkedList_WhenGetTailIsCalled_ThenReturnTheCorrectValue()
    {
        // Arrange
        var input = new int[] { 1, 2, 3, 4 };
        var linkedList = new DataStructures.LinkedList<int>(input);
        linkedList.Reverse();

        // Act
        var result = linkedList.GetTail();

        // Assert
        Assert.Equal(1, result);
    }
}
