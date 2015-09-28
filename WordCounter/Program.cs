using System;
using System.Linq;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1 || string.IsNullOrWhiteSpace(args[0]))
            {
                Console.WriteLine("There are no words in this sentence.");
            }
            else
            {
                var words = (args[0].ToLower().GetWords()).GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
                Console.WriteLine(string.Join("\r\n", words.Select(w => w.Key + " - " + w.Value)));
            }
            Console.Read();
        }
    }
}
