using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.Utils;
using Intermediate.Models;

namespace Intermediate
{
    class IntermediateLatihan3Client
    {
        static void Main(string[] args)
        {
            IWord word = new Word();

            Console.Write("Input kalimat : ");
            String bWord = Console.ReadLine();
            word.inputWord(bWord);

            word.displayConcurenWord();
            word.displayMostWords();

            Console.ReadKey();
        }
    }
}
