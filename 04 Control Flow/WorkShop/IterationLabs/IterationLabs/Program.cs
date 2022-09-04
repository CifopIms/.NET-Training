using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 0, 1, 2, 3, 4 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (number == 2)
                    continue;
                if (number == 3)
                    break;
                Console.WriteLine(number);
            }
            foreach (var number in numbers)
            {
                if (number == 2)
                    continue;
                if (number == 3)
                    break;
                //Console.WriteLine(number);
            }


            var input = string.Empty;//input ="";
            while (true)
            {
                Console.WriteLine("Enter Text or exist:");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input : " + input);
                    continue;
                }
            }

            Console.WriteLine("End of program...");
        }
    }
}
