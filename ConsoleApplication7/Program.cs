using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary
{
    class Program
    {
        // Main function
        static void Main(string[] args)
        {
            FindWords word_obj = new FindWords();       // Object to call functions from FindWords class
            string fileName;                            // Variable for file name
            Console.Write("Enter file name: ");         
            fileName = Console.ReadLine();
            // Making Stream Reader object file will be placed in the same directory as code hence we used "../../"
            StreamReader sr = new StreamReader("../../" + fileName);        
            Dictionary<String, int> word_list = new Dictionary<string, int>();  // List to save words
            while (!sr.EndOfStream)                     // Loop to read file until end
            {
                String[] words = sr.ReadLine().Split(' ');  // Copying words to an array and spliting them using spaces
                foreach (var word in words)                 // Adding all words in the list
                {
                    if (word_list.ContainsKey(word))
                    {
                        word_list[word] = word_list[word] + 1;
                    }
                    else
                    {
                        word_list[word] = 1;
                    }
                }
            }
            String dict_word;
            int option, length, count;
            while (true)                // Loop to get user option
            {
                Console.WriteLine("\n1. Highest word count");
                Console.WriteLine("2. Average word count");
                Console.WriteLine("3. Number of times a word is used");
                Console.WriteLine("4. Get Words based on count");
                Console.WriteLine("5. Get Words based on length");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)     // Switch statement
                {
                    case 1:         // If user chooses option 1
                        Console.WriteLine("Higest Word Count : " + word_obj.MaxCount(word_list));
                        break;
                    case 2:         // If user chooses option 2
                        Console.WriteLine("Average Word Count : " + word_obj.AverageCount(word_list));
                        break;
                    case 3:         // If user chooses option 3
                        Console.Write("Enter a word: ");
                        dict_word = Console.ReadLine();
                        if (word_list.ContainsKey(dict_word))
                        {
                            Console.WriteLine(dict_word + " is used " + word_list[dict_word] + " times");
                        }
                        else
                        {
                            Console.WriteLine(dict_word + " is never used");
                        }
                        break;
                    case 4:         // If user chooses option 4
                        Console.Write("Enter count: ");
                        count = Convert.ToInt32(Console.ReadLine());
                        foreach (var word in word_obj.WordCount(word_list, count))
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case 5:         // If user chooses option 5
                        Console.Write("Enter length: ");
                        length = Convert.ToInt32(Console.ReadLine());
                        foreach (var word in word_obj.WordLength(word_list, length))
                        {
                            Console.WriteLine(word);
                        }
                        break;
                    case 6:
                        return;
                    default:        // If user chooses invalid option
                        Console.WriteLine("Choice Invalid!!. Please Choose again");
                        break;
                }
            }
        }
    }
}
