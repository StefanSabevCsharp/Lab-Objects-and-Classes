using System;
using System.Linq;

namespace Lab_Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
            Random random = new Random();
                int randomIndex = random.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;

            }
            Console.WriteLine(string.Join(Environment.NewLine,words));

        }
    }
}
