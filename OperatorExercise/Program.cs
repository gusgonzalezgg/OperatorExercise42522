using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 4;
            int quotient = a/ b;
            int remainder = a % b;

            Console.WriteLine($"If 'A' equals {a} and 'B' equals {b}");
            Console.WriteLine("By C#'s rules, 'A' divided by 'B' should equal");
            Console.ReadKey();
            Console.WriteLine(quotient);
            Console.WriteLine("And that's because when 'integer' variables are used, any remainder would lead the answer to be rounded down");
            Console.ReadKey();
            Console.WriteLine("However");
            Console.WriteLine("Using the 'Modulus' will only calculate the remainder and provide that as the answer");
            Console.WriteLine($"So applying the modulus operation with {a} and {b} in mind");
            Console.ReadKey();
            Console.WriteLine($"The answer to {a} % {b} is now {remainder}, that make sense?");
            Console.ReadKey();
            Console.WriteLine($"Because {b} goes into {a} {quotient} times, {remainder} is left over - which would be the answer when applying the 'Modulus' operation");
            Console.ReadKey();


        }
    }
}
