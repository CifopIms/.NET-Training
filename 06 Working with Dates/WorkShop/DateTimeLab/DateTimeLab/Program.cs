using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoDate = new DateTime(2019, 11, 24);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour :" + now.DayOfWeek);

            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("ToLongDateString :"+ now.ToLongDateString());
            Console.WriteLine("ToShortDateString :" + now.ToShortDateString());
            Console.WriteLine("ToLongTimeString :" + now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString :" + now.ToShortTimeString());
            Console.WriteLine("ToString :" + now.ToString("dd-MMMM-yy HH:mm:ss", new CultureInfo("en")));


            // Quiz
            var dateTime = new DateTime(2015, 1, 1);
           dateTime.AddYears(1);
            Console.WriteLine(dateTime.Year);

        }
    }
}
