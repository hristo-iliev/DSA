namespace _01_SumAndAvdInts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CalcSumAndAvg
    {
        //01. Write a program that reads from the console a sequence of positive integer numbers.
        //The sequence ends when empty line is entered. Calculate and print the sum and average
        //of the elements of the sequence. Keep the sequence in List<int>.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            var input = Console.ReadLine();
            while (input != "")
            {
                numbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            Console.WriteLine("Sum: ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();
            Console.WriteLine("Average: ");
            Console.WriteLine(numbers.Average());
        }
    }
}
