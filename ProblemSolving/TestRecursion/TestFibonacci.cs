using ProblemSolving.Recursion;

namespace Test.ProblemSolving;

public class TestFibonacci
{
    [Fact]
    public void GetFibonacci_ShouldReturnNFiboNumber()
    {
        Assert.Equal(34, Fibonacci.GetFibonacci(9));
    }

    [Fact]
    public void GetFibonacci_ShouldReturnZero_WhenNIsZero()
    {
        Assert.Equal(0, Fibonacci.GetFibonacci(0));
    }

    [Fact]
    public void GetFibonacci_ShouldReturnOne_WhenNIsOne()
    {
        Assert.Equal(1, Fibonacci.GetFibonacci(1));
    }
}
