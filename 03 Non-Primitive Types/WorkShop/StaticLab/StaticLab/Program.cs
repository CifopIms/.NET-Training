using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace StaticLab
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var Pi = Calculator.Pi;
            //decimal number = 100000000000000000000m + 0.00001m;

            // Class
            //var calculator = new Calculator(); // instance = objet
            //calculator.Reset();
            //Calculator.Pi
            //calculator.Me

            //var result = Calculator.Add(1, 2);
            //Calculator.Reset
            //Calculator.Message














            //var result = Calculator.Result;
            //var result = calculator.Add(1, 2);
            //var result = Calculator.Add(1, 2);
            //System.Console.WriteLine(result);

            // Struct
            //var point = new Point();
            //point.Move(0, 1);

            ////String
            //            var numbers = new int[3] { 1, 2, 3 };
            //            var list = string.Join(",", numbers);
            //            Console.WriteLine(list);

            //            //// Immutable
            //            var message = "Hello";  // Hello
            //            message += " World";    // Hello World
            //            var firstChar = message[0];
            //           // message[0] = 'B';

            //            //Verbatim String
            //            var path = @"C:\mypath\myfolder\


            //sdfsdfdsf



            //sdfsdfsdf



            //sdfsdf
            //";
            var firstName = "John";
            var lastName = "Smith";
            //var name = firstName + " " + lastName;           {0}        {1}
            //var name = string.Format("FullName = {1} {0}", firstName, lastName);
            //var name = $"FullName {firstName} {lastName}"; // 4.6

            var numbers = new int[] { 1, 2, 3 };
            var list = string.Join(",", numbers);

            ////Enums
            var monday = Day.Monday;
            System.Console.WriteLine((byte)monday);

            var day1 = 1;
            if (day1 == (byte)Day.Monday)
            {
                System.Console.WriteLine("It is monday");
            }

            var weekend = Days.Saturday | Days.Sunday; //0100000
                                                       //1000000
                                                       //1100000

            if ((weekend & Days.Saturday) == Days.Saturday)
                System.Console.WriteLine("It is Weekend");

            //System.Console.WriteLine((byte)weekend);            //var calculator = new Calculator();
            ////var result = Calculator.Result;
            ////var result = calculator.Add(1, 2);
            //var result = Calculator.Add(1, 2);
            //System.Console.WriteLine(result);

            //// Struct
            //var point = new Point();
            //point.Move(0, 1);

            ////String
            //var numbers = new int[3] { 1, 2, 3 };
            //var list = string.Join(",", numbers);
            //System.Console.WriteLine(list);

            ////// Immutable
            //var message = "Hello";  // Hello
            //message += " World";    // Hello World

            ////Verbatim String
            //var path = @"C:\mypath\myfolder\";
            //var firstName = "John";
            //var lastName = "Smith";
            ////var name = firstName + " " + lastName;
            ////var name = string.Format("FullName = {0} {1}", firstName, lastName);

            //var name = $"FullName {firstName} {lastName}"; // 4.6

            ////Enums
            ////var monday = Days.Monday;
            ////System.Console.WriteLine((byte)monday);

            ////var day1 = 1;
            ////if (day1 == (byte)Days.Monday)
            ////{
            ////    System.Console.WriteLine("It is monday");
            ////}

            //var weekend = Days.Saturday | Days.Sunday; //1100000
            //                                           //0100000
            //                                           //0100000

            //if ((weekend & Days.Saturday) == Days.Saturday)
            //    System.Console.WriteLine("It is Weekend");

            //System.Console.WriteLine((byte)weekend);
        }
    }
}
