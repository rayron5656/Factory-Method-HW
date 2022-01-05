using System;

namespace Factory_Method_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OuterConstactedC C = new OuterConstactedC(); //Can't create since its private
            C = OuterConstactedC.Create();               // have to use method
        }
    }

    public class OuterConstactedC
    {
        private OuterConstactedC()
        {

        }
        public static OuterConstactedC Create()
        {
            return new OuterConstactedC();
        }
    }
    
}
