namespace _06_RemovingOddTimeOccuringNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RemoveOddTimeOccuringNums
    {
        //Write a program that removes from given sequence all numbers that occur odd number of times. 
        //Example:
        //{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            numbers = RemoveOddOccurrence(numbers);

            Console.WriteLine("Removed odd occurenses:");
            Console.Write("< ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write(">");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static List<int> RemoveOddOccurrence(List<int> numbers)
        {
            var len = numbers.Count;
            numbers.Sort();
            var numbersToDelete = new List<int>();
            for (int i = 0; i < len; i++)
            {
                var repeat = 0;
                var curNum = numbers[i];

                while (i < len && curNum == numbers[i])
                {
                    repeat++;
                    i++;
                }
                if (repeat % 2 != 0)
                {
                    numbersToDelete.Add(curNum);
                    
                }
                i--;
            }

            for (int i = 0; i < numbersToDelete.Count; i++)
            {
                numbers.RemoveAll(n => numbersToDelete[i] == n);
            }

            return numbers;
        }
    }
}
