using System;
using System.Collections.Generic;
using System.IO;

namespace WordFrequencyCounter
{
    public class FileReader
    {
        public List<string> ReadTextFiles(string folderPath)
        {
            List<string> contents = new List<string>();

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory does not exist.");
                return contents;
            }

            string[] files = Directory.GetFiles(folderPath, "*.txt");

            if (files.Length == 0)
            {
                Console.WriteLine("No .txt files found in this folder.");
                return contents;
            }

            foreach (string file in files)
            {
                Console.WriteLine("Reading file: " + Path.GetFileName(file));
                string content = File.ReadAllText(file);
                contents.Add(content);
            }

            return contents;
        }
    }
}