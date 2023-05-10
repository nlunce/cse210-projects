using System;
using System.Collections.Generic;

namespace Develop02
{
    public class DisplayCmd : Command
    {
        Journal _journal;
        public DisplayCmd(Journal journal)
        {
            _journal = journal;
        }
        public void Execute()
        {
            foreach(Entry entry in _journal._entries)
                {
                    Console.WriteLine(entry.GetEntryAsString());
                }

        }

    }
}