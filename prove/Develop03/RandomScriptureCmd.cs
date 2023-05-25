using System;
using System.Collections.Generic;

namespace Develop03
{
    public class RandomScriptureCmd : Command
    {
        Random rand = new Random();
        public string _randomScriptureKey;
        public string _randomScripture = "";
        Bible _bible;
        public RandomScriptureCmd(Bible bible){
            this._bible = bible;

        }
      
        public void Execute()
        {

            this._randomScriptureKey = this._bible._bibleDict.ElementAt(rand.Next(0, this._bible._bibleDict.Count)).Key;
            Console.WriteLine($"{this._randomScriptureKey}\n{this._randomScripture = this._bible._bibleDict[this._randomScriptureKey]._verseText}");
  
        }



    }
}