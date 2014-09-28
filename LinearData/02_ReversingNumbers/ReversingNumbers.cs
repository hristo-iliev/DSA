namespace _02_ReversingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ReversingNumbers
    {
        //02. Write a program that reads N integers from the console and reverses them using a stack.
        //Use the Stack<int> class.

        static void Main(string[] args)
        {
            Console.WriteLine("The sequence ends when empty line is entered");
            Stack<int> numbers = new Stack<int>();

            var input = Console.ReadLine();
            while (input != "")
            {
                numbers.Push(int.Parse(input));
                input = Console.ReadLine();
            }

            Console.WriteLine("Reversed: ");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
