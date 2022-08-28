using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var isFemale = true;
            var name = "Imen";
            var person = new Person();
            person.Name = "Imen";
            person.Introduce();
            var age = person.CalculateAge(1990);
            if(age > 18)
            {

            }
            else
            {

            }
        }
    }
}
