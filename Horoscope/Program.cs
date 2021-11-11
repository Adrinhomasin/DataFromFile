﻿using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscpe");
            string userColor = Console.ReadLine();
            string output = GetLineFromFileData(userColor);

            if (output.Length != 0)
            {
                Console.WriteLine(output);

            }
            else
            {
                Console.WriteLine("sorry horoscope not found");
            }


        }

        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\users\opilane\samples";
            string fileName = "Horoscope.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);
            return dataFromFile;
        }
        private static string GetLineFromFileData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";
            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;
                }

            }
            return result;
        }
    }

}
    

