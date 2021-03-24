using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.Utils;

namespace Intermediate.Models
{
    class Word : BaseWord, IWord
    {
        public int maxOccurence;

        public Word() : base()
        {

        }

        public void inputWord(string word)
        {
            this.word = word;

            // split
            splitDistinctWords();

        }

        public void displayMostWords()
        {
            Console.WriteLine("Kata terbanyak : ");

            calculateMaxOccurence();

            for (int i = 0; i < splitedDistinctWord.Count; i++)
            {
                WordOccurence wOriginal = splitedDistinctWord[i];
                if (wOriginal.occurence == maxOccurence)
                    Console.WriteLine(wOriginal.word);
            }
        }

        private void calculateMaxOccurence()
        {
            for (int i = 0; i < splitedDistinctWord.Count; i++)
            {
                WordOccurence wOriginal = splitedDistinctWord[i];

                if (wOriginal.occurence > maxOccurence)
                    maxOccurence = wOriginal.occurence;
            }
        }

        public string getWord()
        {
            return this.word;
        }

        public void displayConcurenWord()
        {

            for (int i = 0; i < splitedDistinctWord.Count; i++)
            {
                WordOccurence wOriginal = splitedDistinctWord[i];

                for (int j = 0; j < originalWords.Count; j++)
                {
                    string word = originalWords[j];

                    if (wOriginal.word.ToLower() == word.ToLower())
                    {
                        wOriginal.occurence += 1;
                    }
                }

                Console.WriteLine(wOriginal.word + " = " + wOriginal.occurence);
            }
        }
    }
}
