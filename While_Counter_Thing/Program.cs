using System;

/**
 * @author Sigma-One
 */

namespace While_Counter_Thing {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            bool success = true;
            
            do {
                // Write previous value of i and ask for user input
                Console.Write("\r" + i);
                string input = Console
                    .ReadKey(true)
                    .KeyChar
                    .ToString();
                
                // Attempt to parse input, if successful, add to i, else set fail state
                success = int.TryParse(input, out int result);
                i += result;
            } while (success && i < 100);
            
            // Exit messages
            if (!success) { Console.WriteLine("\rNon-integer character entered, Exiting"); }
            else { Console.WriteLine("\rReached 100 (" + i + "), Exiting"); }
        }
    }
}