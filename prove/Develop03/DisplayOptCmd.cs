using System;
using System.Collections.Generic;

namespace Develop03
{
    public class DisplayOptCmd : Command
    {
        public void Execute()
        { 
            Console.Write("\nPlease select one of the following choices:\n1. Random Scripture\n2. Scripture Lookup\nQuit\n> ");

        }

    }
}