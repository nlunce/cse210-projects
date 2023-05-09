using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class Entry
    {
        public string _prompt = "";
        public string _response = "";
        public string _date = "";

        public Entry(){

        }

        public string GetEntryAsString()
        {
            return $"\nDate: {this._date} \nPrompt: {this._prompt}\nResponse: {this._response}";
        }

        public void StoreEntry(string date, string prompt, string response)
        {
            this._prompt = prompt;
            this._response = response;
            this._date = date;
        }


    }
}