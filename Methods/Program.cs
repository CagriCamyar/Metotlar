using System;

namespace Methods
{

    class Program
    {

        static void Main(string[] args)
        {
            Add();
            
            int result = Add2(5, 9);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
    }
}