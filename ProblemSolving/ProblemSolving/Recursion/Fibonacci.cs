namespace ProblemSolving.Recursion
{
    public static class Fibonacci
    {
        // TODO: Add unit testing DONE
        public static int GetFibonacci(int n)
        {
            return n switch
            {
                0 => 0,
                1 => 1,
                _ => GetFibonacci(n - 1) + GetFibonacci(n - 2)
            };
        }
    }
}
