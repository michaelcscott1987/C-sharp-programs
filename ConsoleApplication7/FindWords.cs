using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    // Class for words and functions
    class FindWords
    {
        // Function to get Highest Word Count
        public int MaxCount(Dictionary<String, int> list)
        {
            int max = 0;
            foreach (var key in list.Keys.ToList<String>()) // Comparing every count in the list to find maximum count
            {
                if (max < list[key])
                {
                    max = list[key];
                }
            }
            return max;
        }
        // Function to get Average Word Count
        public double AverageCount(Dictionary<String, int> list)
        {
            double sum = 0;
            List<String> keys = list.Keys.ToList<String>();
            foreach (var key in keys)                      // Adding all counts of word to get average
            {
                sum += list[key];
            }
            return sum / keys.Capacity;                    // Calculating average
        }
        // Function to get Words w.r.t length
        public List<String> WordLength(Dictionary<String, int> list, int length)
        {
            List<String> words = new List<String>();
            foreach (var key in list.Keys.ToList<String>()) // Finding all words in the list that have same length to parameter length
            {
                if (key.Length == length)                   
                {
                    words.Add(key);
                }
            }
            words.Sort();                                   // Sorting all words
            return words;
        }
        // Function to get Word w.r.t Count
        public List<String> WordCount(Dictionary<String, int> list, int count)
        {
            List<String> words = new List<String>();
            foreach (var key in list.Keys.ToList<String>())
            {
                if (list[key] == count)                     // Finding all words in the list that have the same count as given in parameter
                {
                    words.Add(key);
                }
            }
            words.Sort();                                   // Sorting words
            return words;
        }
    }
}
