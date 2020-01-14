using System;

namespace Sortering
{
    class Program
    {
        static void Sortering(int[] tal)
        {
            bool needsSorting = true;
            
            for (int i = 0; i < tal.Length - 1 && needsSorting; i++)
            {
                
                needsSorting = false;
                
                for (int j = 0; j < tal.Length - 1 - i; j++)
                {
                    
                    if (tal[j] > tal[j + 1])
                    {
                        
                        needsSorting = true;
                        
                        int tmp = tal[j + 1];
                        tal[j + 1] = tal[j];
                        tal[j] = tmp;
                    }
                }
                
            }
        }
        static int[] randomgenerator(int storlek)
        {
            Random rnd = new Random();
            int[] tal = new int[storlek];
            for (int i = 0; i < tal.Length; i++)
                tal[i] = rnd.Next(tal.Length);
            return tal;
        }
        static void Main(string[] args)
        {
            int[] storlekar = new int[] { 10, 10000, 100000 };
            for (int i = 0; i < storlekar.Length; i++)
            {
                Console.WriteLine("Skapar slumpad data av längd " + storlekar[i]);
                int[] data = randomgenerator(storlekar[i]);
                DateTime startTid = DateTime.Now;
                Sortering(data);
                TimeSpan deltaTid = DateTime.Now - startTid;
                Console.WriteLine("Det tog {0:0.00} millisekunder att sortera :D.\n", deltaTid.TotalMilliseconds);
                
                
            }
        }
    }
}