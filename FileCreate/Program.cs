using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\wishlist";
            string fileName = "wishlist";
            string FullFilePath = $@"{rootDirectory}\{fileName}.txt";
            Console.WriteLine(FullFilePath);

            bool fileExists = File.Exists(FullFilePath);

            bool directoryExists = File.Exists(FullFilePath);
            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine("wishlist directory doesn't exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(FullFilePath);
                Console.WriteLine($"File {fileName}.txt has been created");
            }
            else
            {
                File.Create(FullFilePath);
                Console.WriteLine($"File {fileName}.txt has been created");
            }
            
        }
    }
}
