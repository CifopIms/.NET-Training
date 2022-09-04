using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 0;
            var customerType = CustomerType.Permium;


            //if ((customerType == (int)CustomerType.Permium) && (customerType == (int)CustomerType.UltraPermium))
            if (customerType == (int)CustomerType.Permium)
                price = 15;
            else
            {
                price = 25;
                Console.WriteLine("price has not been reduced" + price);
            }

            price = (customerType == (int)CustomerType.Permium) ? 15 : 25;



            switch (customerType)
            {
                case CustomerType.UltraPermium:
                case CustomerType.Permium:
                    price = 15;
                    break;
                case CustomerType.Normal:
                    price = 20;
                    break;
                default:
                    price = 25;
                    break;
            }

        }
    }
}
