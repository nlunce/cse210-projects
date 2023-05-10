using System;
using System.Collections.Generic;

namespace Develop02
{
    public class WriteCmd : Command
    {
        private Prompts _prompts;
        private Journal _journal;
        public WriteCmd(Prompts prompts, Journal journal)
        {
            _prompts = prompts;
            _journal = journal;

        }
        public void Execute()
        {
            Entry entry = new Entry();
            string prompt = _prompts.GetRandomPrompt();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string response = Console.ReadLine();
            entry.StoreEntry(currentDate, prompt, response);
            _journal.StoreEntry(entry);

        }

    }
}