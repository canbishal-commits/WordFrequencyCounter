using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyCounter
{
    public class TextProcessor
    {
        public List<string> ProcessText(string text, int n, int m)
        {
            List<string> words = new List<string>();

            string[] splitWords = Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in splitWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    string processedWord = word;

                    if (processedWord.Length > n && processedWord.Length > m)
                    {
                        processedWord = processedWord.Substring(0, processedWord.Length - m);
                    }

                    words.Add(processedWord);
                }
            }

            return words;
        }
    }
}