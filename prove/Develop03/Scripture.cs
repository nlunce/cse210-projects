using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Scripture
    {
        public string _bookName = "";
        public string _bookNumber = "";
        public string _chapterNumber = "";
        public string _verseNumber = "";
        public string _verseText = "";
        public string _scriptureRef = "";


        public void Store(string bookName, string bookNumber, string chapterNumber, string verseNumber, string verseText)
        {
            this._bookName = bookName;
            this._bookNumber = bookNumber;
            this._chapterNumber = chapterNumber;
            this._verseNumber = verseNumber;
            this._verseText = verseText;
            this._scriptureRef = $"{this._bookName} {this._chapterNumber}:{this._verseNumber}";

        }
        
        public Scripture()
        {

        }


    
    }
    
}