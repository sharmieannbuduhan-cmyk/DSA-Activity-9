
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> words = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Hello", "Mandik"},
            {"Good morning", "sa una lang yan"},
            {"Good afternoon", "Naimbag a malem"},
            {"Good evening", "Naimbag a rabii"},
            {"Thank you", "no thanks"},
            {"Yes", "Wen"},
            {"No", "Saan"},
            {"Water", "Danum"},
            {"Food", "Makan"},
            {"ILoveYou", "Kagkagura ka"}
        };

        string choice = "Y";

        while (choice == "Y")
        {
            Console.WriteLine("\nAVAILABLE WORDS:");

            foreach (var word in words)
            {
                Console.WriteLine("- " + word.Key);
            }

            Console.Write("\nEnter the English word to translate: ");
            string input = Console.ReadLine();

            if (words.ContainsKey(input))
            {
                Console.WriteLine("\nTranslation: " + words[input]);
            }
            else
            {
                Console.WriteLine("\nSorry, the word does not exist in the dictionary.");
            }

            Console.Write("\nDo you want to translate another word? (Y/N): ");
            choice = Console.ReadLine().ToUpper();

            if (choice != "Y")
            {
                Console.WriteLine("\nThank you for using the translator!");
            }
        }
    }
}

