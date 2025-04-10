namespace Strings_shepardson_bruce
{
    internal class Program
    {
        // Main method - entry point of the application
        static void Main(string[] args)
        {
            // Prompt user to input a character
            Console.WriteLine("please input a character");

            // Read a single character input from the user
            char mychar = Console.ReadKey().KeyChar;

            // Check if the input character is a letter using the Char.IsLetter method
            bool isLetter = Char.IsLetter(mychar);

            // Output the result of whether the character is a letter or not
            Console.WriteLine($"\n{mychar} is a letter: {isLetter}.");

            // Ask the user why they like video games
            Console.WriteLine("why do you like video games?");

            // Read the sentence input by the user
            string sentence = Console.ReadLine();

            // Prompt user to enter a word to search for in the sentence
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            // Check if the input word exists within the sentence
            bool isIn = sentence.Contains(word);

            // Output whether the word exists in the sentence or not
            Console.WriteLine($"{word} exists in {sentence}, {isIn}");
        }
    }
}
