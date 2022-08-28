using System;

namespace StaticLab
{
    partial class Program
    {
        public enum Day : byte      
        {
            Monday = 1 ,
            Tuesday ,
            Wenesday ,
            Thursday,
            Firday,
            Saturday,
            Sunday
        }

        [Flags]
        public enum Days : byte
        {
            None = 0,       //0000000
            Monday = 1,     //0000001
            Tuesday = 2,    //0000010
            Wenesday = 4,   //0000100
            Thursday = 8,   //0001000
            Firday = 16,    //0010000
            Saturday = 32,  //0100000
            Sunday = 64,    //1000000
            All = 127,      //1111111
        }




    }
}
