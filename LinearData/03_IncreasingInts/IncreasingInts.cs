namespace _03_IncreasingInts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IncreasingInts
    {
        //03. Write a program that reads a sequence of integers (List<int>) ending with an empty
        //line and sorts them in an increasing order.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            var input = Console.ReadLine();
            while (input != "")
            {
                numbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            Console.WriteLine("Sorted Increasing: ");
            numbers.Sort();
            var len = numbers.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
