namespace _04_LongestSubsequenceOfEqualInts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LongestSubsequence
    {
        //04. Write a method that finds the longest subsequence of equal numbers in given List<int>
        //and returns the result as new List<int>. Write a program to test whether the method works correctly.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{
                2, 3, 3, 3, 4, 4, 2, 2, 5, 5, 5, 5, 7, 7};

            var max = FindMaxSequence(numbers);
            Console.Write("< ");
            for (int i = 0; i < max.Count; i++)
            {
                Console.Write(max[i] + " ");
            }
            Console.Write(">");
            Console.WriteLine();
                        
        }

        public static List<int> FindMaxSequence(List<int> numbers)
        {
            List<int> max = numbers.Select((n, i) => new { Value = n, Index = i })
                .OrderBy(s => s.Value)
                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
                .GroupBy(s => new { s.Value, s.Diff })
                .OrderByDescending(g => g.Count())
                .First()
                .Select(f => f.Value)
                .ToList();

            return max;
        }
    }
}
