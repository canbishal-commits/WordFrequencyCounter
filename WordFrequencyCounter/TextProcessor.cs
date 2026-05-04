using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyCounter
{
    public class TextProcessor
    {
        public List<string> ProcessText(string text)
        {
            List<string> words = new List<string>();

            string[] splitWords = Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in splitWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    words.Add(word);
                }
            }

            return words;
        }
    }
}