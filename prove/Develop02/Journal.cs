using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02{
    public class Journal
    {
        public List<Entry> _entries;

        public Journal()
        {
             this._entries = new List<Entry>();
        }

        public List<Entry> GetAllEntries()
        {
            return this._entries;

        }

        public void StoreEntry(Entry entry)
        {
            if(!this._entries.Contains(entry))
            {
                this._entries.Add(entry);
            }
        }

        
    }
}
