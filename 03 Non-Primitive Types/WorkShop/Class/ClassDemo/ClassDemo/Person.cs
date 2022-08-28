using System;

namespace ClassDemo
{
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            // Write in Console
            Console.WriteLine("Hi! My Name is " + Name);

            // Write in File 

            // Write in Database
        }

        public int CalculateAge(int yearOfBirthday)
        {
            return DateTime.Now.Year - yearOfBirthday;
        }
    }
}
