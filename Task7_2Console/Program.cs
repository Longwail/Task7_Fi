using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            str = Console.ReadLine();

            string[] words = str.Split(' ');

            List<string> result = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(str)) throw new Exception("Пустая строка!!");

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    int count = 0;

                    foreach (string w in words)
                        if (w == word) count++;

                    if (count == 1) result.Add(word);
                }

                if (result.Count == 0) throw new Exception("Нет слов!");

                foreach (string item in result)
                    Console.WriteLine(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}