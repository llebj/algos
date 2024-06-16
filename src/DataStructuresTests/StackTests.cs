namespace DataStructuresTests;

public class StackTests
{
    [Fact]
    public void GivenAnEmptyStack_WhenPeek_ThenThrowInvalidOperationException()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Fact]
    public void GivenAnEmptyStack_WhenAnItemIsPushed_ThenTheStackIsNotEmpty()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();

        // Act
        stack.Push(1);

        // Assert
        Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void GivenAStackWithAnItem_WhenPeek_ThenReturnTheValueAndTheStackIsNotEmpty()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);

        // Act
        var result = stack.Peek();

        // Assert
        Assert.Equal(1, result);
        Assert.False(stack.IsEmpty);
    }

    [Fact]
    public void GivenAStackWithMultipleItems_WhenPeek_ThenReturnTheLastItem()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);
        stack.Push(2);

        // Act
        var value = stack.Peek();

        // Assert
        Assert.Equal(2, value);
    }

    [Fact]
    public void GivenAnEmptyStack_WhenAnItemIsPopped_ThenThrowAnInvalidOperationException()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();

        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void GivenAStackWithAnItem_WhenAnItemIsPopped_ThenReturnTheItemAndTheStackIsEmpty()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);

        // Act
        var result = stack.Pop();

        // Assert
        Assert.Equal(1, result);
        Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void GivenAStackWithMultipleItems_WhenAnItemIsPopped_ThenReturnTheLastItemAndTheItemIsNotEmpty()
    {
        // Arrange
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);
        stack.Push(2);

        // Act
        var value = stack.Pop();

        // Assert
        Assert.Equal(2, value);
        Assert.False(stack.IsEmpty);
    }
}
