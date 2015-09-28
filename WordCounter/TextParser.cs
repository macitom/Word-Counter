using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    public static class TextParser
    {
        public static IEnumerable<string> GetWords(this string text)
        {
            var word = new StringBuilder();
            foreach (var c in text)
            {
                if (char.IsPunctuation(c) || char.IsWhiteSpace(c) || char.IsSeparator(c))
                {
                    if (word.Length > 0)
                    {
                        yield return word.ToString();
                        word.Clear();
                    }
                }
                else
                {
                    word.Append(c);
                }
            }
            if (word.Length > 0)
            {
                yield return word.ToString();
            }
        }
    }
}