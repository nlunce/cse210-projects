using System;
using System.Collections.Generic;

namespace Develop02
{
    public class SaveCmd : Command
    {
        Journal _journal;
        string _fileName;
        
        public SaveCmd(Journal journal)
        {
            _journal = journal;

        }
        public void Execute()
        {
            
            Console.Write("What file would you like to save to? \n> ");
            this._fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(this._fileName)) 
            {
                foreach (Entry entry in this._journal._entries) 
                {
                    string line = entry._date + "," + entry._prompt + "," + entry._response;
                    writer.WriteLine(line);
                }

            }

        }

    }
}