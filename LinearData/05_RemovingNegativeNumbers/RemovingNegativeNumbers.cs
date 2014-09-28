namespace _05_RemovingNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RemovingNegativeNumbers
    {
        //05. Write a program that removes from given sequence all negative numbers.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{
                2, 3, -3, -3, 4, 4, -2, 2, 5, -5, 5, 5, -7, 7};

            Console.WriteLine("Given List:");
            Console.Write("< ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write(">");
            Console.WriteLine();
            Console.WriteLine();
                        
            numbers.RemoveAll(i => i < 0);

            Console.WriteLine("With removed negative numbers:");
            Console.Write("< ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write(">");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
