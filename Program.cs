using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            SortedDictionary<char, int> symbolsOccurances = new SortedDictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                char currSymbol = inputText[i];

                if (!symbolsOccurances.ContainsKey(currSymbol))
                {
                    symbolsOccurances.Add(currSymbol, 0);
                }

                symbolsOccurances[currSymbol]++;
            }

            PrintSymbolOccurances(symbolsOccurances);
        }

        private static void PrintSymbolOccurances(SortedDictionary<char, int> symbolsOccurances)
        {
            foreach (var symbol in symbolsOccurances)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
