using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Bible
    {
        public string _fileName = "kjv.csv";

        public Dictionary<string, Scripture> _bibleDict = new Dictionary<string, Scripture>();
        
        public Bible()
        {
            using (StreamReader reader = new StreamReader(this._fileName)) 
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) 
                    {
                        string[] parts1 = line.Split('"');
                        string[] parts = line.Split(',');
                        Scripture scripture = new Scripture();
                        scripture.Store(parts[1], parts[2], parts[3], parts[4], parts1[parts1.Length - 2]);
                        this._bibleDict.Add(scripture._scriptureRef, scripture);
                        
                    };

                }  
        }
    }
}