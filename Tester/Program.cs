using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            


            if (File.Exsists("words.txt"))
            {
                  String[] words = File.ReadAllLines("words.txt");
            
                  Console.WriteLine(words[0]);

            }
            
        }
    }
}
