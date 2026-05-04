using System;
using System.Collections.Generic;

namespace WordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Frequency Counter - Version 1");
            Console.Write("Enter folder path: ");
            string folderPath = Console.ReadLine();

            FileReader fileReader = new FileReader();
            TextProcessor textProcessor = new TextProcessor();
            WordCounter wordCounter = new WordCounter();

            List<string> fileContents = fileReader.ReadTextFiles(folderPath);

            foreach (string content in fileContents)
            {
                List<string> words = textProcessor.ProcessText(content);
                wordCounter.CountWords(words);
            }

            Console.WriteLine("\nWord Frequency Results:");
            wordCounter.DisplayResults();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}