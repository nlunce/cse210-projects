using System;
using System.Collections.Generic;

namespace Develop02
{
    public class LoadCmd : Command
    {
        private string _fileName;
        private Journal _journal;
        public LoadCmd(Journal journal)
        {
            _journal = journal;
            
        }
        public void Execute()
        {
            Console.Write("What file would you like to load from? \n> ");
            this._fileName = Console.ReadLine();
            
            if(File.Exists(this._fileName))
            {
                _journal._entries.Clear();

                using (StreamReader reader = new StreamReader(this._fileName)) 
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) 
                    {
                        string[] parts = line.Split(',');
                        Entry entry = new Entry();
                        entry.StoreEntry(parts[0], parts[1], parts[2]);
                        _journal.StoreEntry(entry);
                    };

                    

                }
              
            }
            else
            {
                Console.Write("\nNo such file in current directory.\n");
            }

        }

    }
}