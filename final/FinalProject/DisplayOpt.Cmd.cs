using System;
using System.Collections.Generic;

namespace TwitterBot
{
    public class DisplayOptCmd : ICommand
    {
        public void Execute()
        {
            Console.Write("\nPlease select one of the following choices:\n1. Tweet\n2. Quit\n> ");

        }

    }
}