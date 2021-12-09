using System;

namespace Sugar
{
    internal class Program
    {
        static void Main(string[] args)

        {
            var num1 = 4;
            var answer = 4 < 9 ? $"{num1} Is less than 9 " : "Is equal or greater than 9";
            Console.WriteLine(answer);
        }
    }
}
