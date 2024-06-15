namespace DataStructuresTests;

public class QueueTests
{
    [Fact]
    public void GivenAnEmptyQueue_WhenPeek_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }

    [Fact]
    public void GivenAnEmptyQueue_WhenAValueIsEnqueued_ThenTheQueueIsNotEmpty()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();

        // Act
        queue.Enqueue(1);

        // Assert
        Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void GivenAQueueWithAnItem_WhenPeek_ThenReturnTheFirstValueAndTheQueueIsNotEmpty()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(1);

        // Act
        var result = queue.Peek();

        // Assert
        Assert.Equal(1, result);
        Assert.False(queue.IsEmpty);
    }

    [Fact]
    public void GivenAQueueWithMultipleItems_WhenPeek_ThenReturnTheFirstValue()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        // Act
        var result = queue.Peek();

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void GivenAnEmptyQueue_WhenAnItemIsDequeued_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Fact]
    public void GivenAQueueWithAnItem_WhenTheItemIsDequeued_ThenReturnTheCorrectValueAndTheQueueIsEmpty()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(1);

        // Act
        var result = queue.Dequeue();

        // Assert
        Assert.Equal(1, result);
        Assert.True(queue.IsEmpty);
    }

    [Fact]
    public void GivenAQueueWithMultipleItems_WhenAnItemIsDequeued_ThenReturnTheCorrectValueAndTheQueueIsNotEmpty()
    {
        // Arrange
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        // Act
        var result = queue.Dequeue();

        // Assert
        Assert.Equal(1, result);
        Assert.False(queue.IsEmpty);
    }
}
