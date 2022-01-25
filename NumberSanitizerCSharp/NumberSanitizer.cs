/*
FindByShortName
FindByType
GetByAncs
InfluencingOn

Part 1: Find all flows from input (Console.ReadLine()) to output (Console.WriteLine()).
Part 2: Find all flows from input (Console.ReadLine()) to output (Console.WriteLine()). Output has to be in an if statement
Part 3: Remove any flows that are sanitized using: InfluencingOnAndNotSanitized
*/

using System;
using System.Linq;

class NumberSanitizer
{
    static void Main(string[] args)
    {
        Console.Write(">>> ");
        string maybeANumber = Console.ReadLine();
        object number = -1;
        
        // The line below is considered by Checkmarx to be a Sanitizer... 
        // bool success = int.TryParse(maybeANumber, out number);

        // ...but let's try to use a very custom code.
        Tuple<object, bool> myCustomSanitizerResult = myCustomSanitizer(maybeANumber);
        bool success = myCustomSanitizerResult.Item2;
        number = myCustomSanitizerResult.Item1;

        if (success) {
            Console.WriteLine("Result: " + number);
        }

        Console.WriteLine("Attempted number: " + maybeANumber);
    }

    static Tuple<object, bool> myCustomSanitizer(string maybeANumber) 
    {
        if (maybeANumber.All(char.IsDigit)) {
            return new Tuple<object, bool>( 
                maybeANumber,
                true
            );
        }

        return new Tuple<object, bool>(-1, false);
    }
}