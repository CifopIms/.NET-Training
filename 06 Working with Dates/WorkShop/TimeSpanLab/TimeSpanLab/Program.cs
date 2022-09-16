using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            // Use Case
            var orderCreateDate =new DateTime(2022,01,05);
            var now = DateTime.Now;
            var duration = now - orderCreateDate;
            var date = DateTime.Now;
            var anotherDate = date.AddMinutes(5);
            if(duration > TimeSpan.FromDays(20) )
            //if(duration >  new TimeSpan(20,0,0,0))
            { 
                // Send Alert Email...
            }
            Console.WriteLine("Duration :" + duration);

            //Properties
            Console.WriteLine("Minutes :" + timeSpan.Minutes);
            Console.WriteLine("total Minutes :" + timeSpan.TotalMinutes);

            //Add
            timeSpan.Add(TimeSpan.FromMinutes(10));
            Console.WriteLine("Add :" + timeSpan.Add(TimeSpan.FromMinutes(8)));
           
            Console.WriteLine("Substract :" + timeSpan.Subtract(TimeSpan.FromMinutes(10)));
            
            //ToString
            Console.WriteLine("ToString :" + timeSpan.ToString());

            var TimeSpanFromString = TimeSpan.Parse("01:02:03");
            //Parse
            Console.WriteLine("Parse :" + TimeSpan.Parse("01:02:03"));

        }
    }
}
