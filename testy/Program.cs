using System;

namespace TestyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var myFunctions = new testy.MyFunctions();
            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = myFunctions.SumArray(numbers);


            Console.WriteLine($"Suma liczb tablicy: {sum}");

            Console.ReadLine();
        }
    }
}


