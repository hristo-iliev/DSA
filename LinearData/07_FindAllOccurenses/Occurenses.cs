namespace _07_FindAllOccurenses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Occurenses
    {
        //Write a program that finds in given array of integers (all belonging to the range [0..1000])
        //how many times each of them occurs.
        //    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        //    2  2 times
        //    3  4 times
        //    4  3 times


        static IDictionary<T, int> GroupByOccurrence<T>(IEnumerable<T> elements)
        {
            return elements.GroupBy(el => el).ToDictionary(group => group.Key, group => group.Count());
        }

        static void Main()
        {
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Console.WriteLine(string.Join(" ", GroupByOccurrence(numbers)));
        }
    }
}
