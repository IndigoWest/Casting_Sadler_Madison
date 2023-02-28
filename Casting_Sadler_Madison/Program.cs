// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Casting_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Asks user what their favorite number is
            Console.WriteLine("What is your favorite number?");
            // Assigns user input to faveNumber variable
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            // Comments on user's favorite number and calls it interesting
            Console.WriteLine("So your favorite number is " + faveNumber + "? Interesting...");

            // Asks user if they like Undertale and requires the user to answer with true or false
            Console.WriteLine("Do you like Undertale? (Please enter 'true' or 'false')");
            // Assigns user input to boolean isTrue
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            // Comments on user's answer and calls it very interesting
            Console.WriteLine($"So it's {isTrue} that you like Undertale? Very interesting...");

            // Calls the user a fool and says it has been tracing the device while the user was answering questions
            Console.WriteLine("You fool! While you've been answering these questions, I've been tracing your device...");
            // Assigns user input
            Console.ReadLine();
            // Tells the user it's tracing their location
            Console.WriteLine("Tracing location. . .");
            // Assigns user input
            Console.ReadLine();
            // Tells the user their location is found
            Console.WriteLine("Location found.");
            // Tells the user they will hear a knock at their front door soon
            Console.WriteLine("You should hear a knock at your front door very soon...");
            // Assigns the user input
            Console.ReadLine();

            // Asks user if they didn't hear the knock and requires the answer to be true or false
            Console.WriteLine("You... You didn't actually hear a knock... Right? (Please enter 'true' or 'false')");
            // Assigns user input to boolean isreallyTrue
            bool isreallyTrue = Convert.ToBoolean(Console.ReadLine());
            // Replies to user and says that hopefully it's a good sign if whether or not the user heard a knock
            Console.WriteLine($"Okay... Phew. So it is {isreallyTrue} that you didn't hear a knock... Hopefully that's a good sign...");

            // Tells the user it was joking and it hopes they liked the program
            Console.WriteLine("I was just joking with you... Anyway, hope you liked the program!");
            // Assigns the user input
            Console.ReadLine();
            // Waits for the user to exit the program
            Console.WriteLine("...");
            // Tells the user they can just go
            Console.WriteLine("You can just go now...");
        }
    }
}
