using System;
using System.Collections.Generic;

namespace Develop02
{
    public class DisplayOptCmd : Command
    {
        public void Execute()
        {
            Console.Write("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n> ");

        }

    }
}