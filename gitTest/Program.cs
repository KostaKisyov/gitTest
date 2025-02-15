
namespace gitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Random random = new Random();

            string name = GetRandomWord(names, random);
            string place = GetRandomWord(places, random);
            string verb = GetRandomWord(verbs, random);
            string noun = GetRandomWord(nouns, random);
            string adverb = GetRandomWord(adverbs, random);
            string detail = GetRandomWord(details, random);

            string sentence = $"{name} from {place} {adverb} {verb} {noun} {detail}.";
            Console.WriteLine("Here is your random sentence:");
            Console.WriteLine(sentence);
        }

        static string GetRandomWord(string[] words, Random random)
        {
            int index = random.Next(words.Length);
            return words[index];
        }
    
    }
}
