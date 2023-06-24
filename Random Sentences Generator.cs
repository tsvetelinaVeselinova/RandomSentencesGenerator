using System;

namespace Random_Sentences_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Peter", "Anne", "Linda", "Marie", "Terrie", "Rosy", "Tsvety" };
            string[] lastNames = { "Smith", "Wilson", "Lee", "Taylor", "Baker", "Evans", "Allen" };
            string[] places = { "Sofia", "Veliko Tarnovo", "Ruse", "Varna", "Stara Zagora", "Pleven" };
            string[] verbs = { "takes", "drinks", "eats", "plays with", "runs", "works" };
            string[] adjective = { "big", "small", "old", "important", "same", "new" };
            string[] nouns = { "phone", "cup", "watch", "computer", "paper", "camera" };
            string[] adverbs = { "calmly", "sadly", "slowly", "warmly", "dizzily" };
            string[] details = { "at the beach", "near the river", "at work", "at home" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");

            while (true)
            {
                string randomFirstName = GetRandomWord(firstNames);
                string randomLastName = GetRandomWord(lastNames);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomAdjective = GetRandomWord(adjective);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomFirstName} {randomLastName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomAdjective} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");

                Console.ReadLine();

            }

        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}
