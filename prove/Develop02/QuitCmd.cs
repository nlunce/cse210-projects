using System;
using System.Collections.Generic;

namespace Develop02
{
    public class QuitCmd : Command
    {
        private bool _quit = false;
        public void Execute()
        {
            this._quit = true;
            
        }

        public bool IsQuit()
    {
        return _quit;
    }

    }
}