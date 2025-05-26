using ProblemSolving.Recursion;

namespace Test.ProblemSolving;

public class TestFactorial
{
    [Fact]
    public void SolveFactorial_ShouldReturnFactorialOfNumber()
    {
        Assert.Equal(6, Factorial.SolveFactorial(3));
    }

    [Fact]
    public void SolveFactorial_ShouldReturnOne_WhenNIsZero()
    {
        Assert.Equal(1, Factorial.SolveFactorial(0));
    }
    
    [Fact]
    public void SolveFactorial_ShouldThrowException_WhenNIsLowerThanZero()
    {
        Assert.Throws<ArgumentException>(() => Factorial.SolveFactorial(-5));
    }
}
