using System.Runtime.Remoting.Messaging;

namespace StaticLab
{
    public class Calculator
    {
        public static string Message;
        public int Result;
        public static int Counter = 0;

        //public int ResultNonStatic;
        //public void MethodNonStatic()
        //{
        //}

        public const float Pi = 3.14f;
        //public string OperationType;

        public static int Add(int a, int b)
        {
            Message = "Result";
            return a + b;
        }
        public void Reset()
        {
            Result = Add(1,2);
            Message = "Result";
        }
    }
    public class Utils
    {
        public int Process(int a , int b)
        {
            var calculator = new Calculator();
            calculator.Reset();
            return a + b;
        }
    }
}
