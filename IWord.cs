using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate.Utils
{
    interface IWord
    {
        string getWord();
        void inputWord(string word);
        void displayMostWords();
        void displayConcurenWord();
    }
}
