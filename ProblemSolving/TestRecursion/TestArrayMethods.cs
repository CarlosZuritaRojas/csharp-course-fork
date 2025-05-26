using ProblemSolving.Recursion;

namespace Test.ProblemSolving;

public class TestArrayMethods
{
    [Fact]
    public void Sum_ShouldSumAllTheElements()
    {
        int[] array = { 1, 2, 3 };

        Assert.Equal(6, ArrayMethods.Sum(array));
    }

    [Fact]
    public void Sum_ShouldReturnZero_WhenArrayIsEmpty()
    {
        int[] array = [];

        Assert.Equal(0, ArrayMethods.Sum(array));
    }
}