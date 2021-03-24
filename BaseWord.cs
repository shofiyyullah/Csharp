using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate.Models
{
    class BaseWord
    {
        public string word;
        public List<WordOccurence> splitedDistinctWord;
        public List<string> originalWords;


        public BaseWord()
        {
            splitedDistinctWord = new List<WordOccurence>();
            originalWords = new List<string>();
        }

        protected void splitDistinctWords()
        {
            originalWords = word.Split(' ').ToList();
            foreach (string s in originalWords)
            {
                if (!isAlreadyExist(s))
                {
                    WordOccurence wo = new WordOccurence();
                    wo.word = s;
                    wo.occurence = 0;
                    splitedDistinctWord.Add(wo);
                }
            }
        }

        private bool isAlreadyExist(string word)
        {
            for (int i = 0; i < splitedDistinctWord.Count; i++)
            {
                if (word.ToLower() == splitedDistinctWord[i].word.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
