using System;

namespace Random_Sentences_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Anne", "Linda", "Marie"};
            string[] places = { "Sofia", "Veliko Tarnovo", "Ruse", "Varna"};
            string[] verbs = { "takes", "drinks", "eats", "plays with"};
            string[] nouns = { "phone", "cup", "watch", "computer"};
            string[] adverbs = { "calmly", "sadly", "slowly", "warmly"};
            string[] details = { "at the beach", "near the river", "at work"};

            Console.WriteLine("Hello, this is your first random-generated sentence: "); 

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb= GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
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
