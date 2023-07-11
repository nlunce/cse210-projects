namespace TwitterBot
{
    public class QuitCmd : ICommand
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