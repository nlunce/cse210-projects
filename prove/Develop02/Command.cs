using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Command
    {
        public string _choice;
        public string _fileName;
        public bool _quit = false;


        Journal journal = new Journal();
        Prompts prompts = new Prompts();



        public void SaveEntriesToFile(string filename) 
        {
            using (StreamWriter writer = new StreamWriter(filename)) 
            {
                foreach (Entry entry in journal._entries) 
                {
                    string line = entry._date + "," + entry._prompt + "," + entry._response;
                    writer.WriteLine(line);
                }

            }
        }

        public void LoadEntriesFromFile(string filename) 
        {
            journal._entries.Clear();
            using (StreamReader reader = new StreamReader(filename)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string[] parts = line.Split(',');
                    Entry entry = new Entry();
                    entry.StoreEntry(parts[0], parts[1], parts[2]);
                    journal.StoreEntry(entry);
                };

                   
            }
        }

        public void DisplayOptions()
        {
            Console.Write("\r\nPlease select one of the following choices:\r\n1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit\r\n> ");
        }

        public void GetInput()
        {
            this._choice = Console.ReadLine();


            if(this._choice == "1" | this._choice == "Write" | this._choice == "write")
            {
                Entry entry = new Entry();
                string prompt = prompts.GetRandomPrompt();
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string response = Console.ReadLine();
                entry.StoreEntry(prompt, response, currentDate);
                journal.StoreEntry(entry);
            }
            else if(this._choice == "2" | this._choice == "Display" | this._choice == "display")
            {
                foreach(Entry entry in journal._entries)
                {
                    Console.WriteLine(entry.GetEntryAsString());
                }
            }
            else if(this._choice == "3" | this._choice == "Load" | this._choice == "load")
            {   
                Console.Write("What file would you like to load from? \n> ");
                this._fileName = Console.ReadLine();
                this.LoadEntriesFromFile(this._fileName);



            }
            else if(this._choice == "4" | this._choice == "Save" | this._choice == "save")
            {
                Console.Write("What file would you like to save to? \n>");
                this._fileName = Console.ReadLine();

                this.SaveEntriesToFile(_fileName);

            }
            else if(this._choice == "5" | this._choice == "Quit" | this._choice == "quit")
            {
                this._quit = true;
            }
            else
            {
                Console.WriteLine("\r\nInvalid Input");  
                this.DisplayOptions();
                this.GetInput();
            }
        }






    }
}
