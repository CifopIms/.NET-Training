using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // 11

            var person = new Person { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // 30











            var message = string.Empty;
            message = SayHello(message);
            Console.WriteLine(message);

           
        }

        private static string SayHello(string message)
        {
            message = "Hello world";
            return message;
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }
      
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
