using System;
using System.Collections.Generic;

namespace WordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Frequency Counter - Version 2");
            Console.Write("Enter folder path: ");
            string folderPath = Console.ReadLine();

            Console.Write("Enter N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter M value: ");
            int m = Convert.ToInt32(Console.ReadLine());

            FileReader fileReader = new FileReader();
            TextProcessor textProcessor = new TextProcessor();
            WordCounter wordCounter = new WordCounter();

            List<string> fileContents = fileReader.ReadTextFiles(folderPath);

            foreach (string content in fileContents)
            {
                List<string> words = textProcessor.ProcessText(content, n, m);
                wordCounter.CountWords(words);
            }

            Console.WriteLine("\nWord Frequency Results:");
            wordCounter.DisplayResults();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}