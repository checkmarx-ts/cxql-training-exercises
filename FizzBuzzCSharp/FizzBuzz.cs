using System;

namespace FizzBuzz
{
    class FizzBuzzExample 
    {         
        static void Main(string[] args)
        {
            System.Console.Write(">>> ");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++) {
                string buffer = "";
                if (i % 3 == 0) buffer += "Fizz";
                if (i % 5 == 0) buffer += "Buzz";
                Console.WriteLine(buffer.Length > 0 ? buffer : i.ToString());
            }
        }
    }
}