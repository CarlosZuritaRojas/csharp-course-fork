using System.Diagnostics;
using System.Linq;

namespace ProblemSolving
{
    /// <summary>
    /// Given a string represeting a paragraph, find the first word
    /// that repeats. Return the word itself. If no word is repeated,
    /// return null.
    /// 
    /// - Words are case-insensitive (This = this)
    /// - Punctuation should be ignored (even, = even)
    /// - Consider only alphanumeric characters as part of words
    /// 
    /// Input:
    /// "This is a test for you, students, this is the best"
    /// Output:
    /// "this"
    /// 
    /// Best data structure
    /// </summary>
    public class FindTheFirstRepeatedWordProblem
    {
        private readonly Dictionary<string, int> foundWords = new();

        public string? Process(string paragraph)
        {
            List<string> words = paragraph.ToLower()
                                            .Split(" ")
                                            .Select(x => x.Trim(','))
                                            .ToList();

            var counter = 0;
            while (words.Count > counter)
            {
                if (foundWords.TryGetValue(words[counter], out int value) && value == 1)
                {
                    return words[counter];
                }

                foundWords[words[counter]] = 1;
                counter++;
            }

            Console.WriteLine("No repeated words found");
            return null;
        }
    }
}
