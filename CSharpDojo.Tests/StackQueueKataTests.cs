using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class StackQueueKataTests
{
    // IsValidParentheses tests
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)]
    public void IsValidParentheses_ShouldValidateCorrectly(string input, bool expected)
    {
        Assert.Equal(expected, StackQueueKata.IsValidParentheses(input));
    }

    // MinStack tests
    [Fact]
    public void MinStack_ShouldTrackMinimum()
    {
        var stack = new MinStack();
        stack.Push(3);
        stack.Push(5);
        Assert.Equal(3, stack.GetMin());

        stack.Push(2);
        stack.Push(1);
        Assert.Equal(1, stack.GetMin());

        stack.Pop();
        Assert.Equal(2, stack.Top());
        Assert.Equal(2, stack.GetMin());

        stack.Pop();
        Assert.Equal(5, stack.Top());
        Assert.Equal(3, stack.GetMin());
    }

    [Fact]
    public void MinStack_ShouldThrowWhenEmpty()
    {
        var stack = new MinStack();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Throws<InvalidOperationException>(() => stack.Top());
        Assert.Throws<InvalidOperationException>(() => stack.GetMin());
    }

    // QueueUsingStacks tests
    [Fact]
    public void QueueUsingStacks_ShouldDequeueInOrder()
    {
        var queue = new QueueUsingStacks<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.Equal(1, queue.Peek());
        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Peek());
        Assert.Equal(2, queue.Dequeue());
        Assert.Equal(3, queue.Dequeue());
    }

    [Fact]
    public void QueueUsingStacks_ShouldThrowWhenEmpty()
    {
        var queue = new QueueUsingStacks<int>();
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }
}
