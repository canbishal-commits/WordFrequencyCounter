using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyCounter
{
    public class WordCounter
    {
        private Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        public void CountWords(List<string> words)
        {
            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }
        }

        public void DisplayResults()
        {
            foreach (var item in wordFrequency.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}