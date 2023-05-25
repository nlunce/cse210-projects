using System;
using System.Collections.Generic;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Bible bible = new Bible();


            QuitCmd quitCommand = new QuitCmd();
            DisplayOptCmd displayOptionsCommand = new DisplayOptCmd();
            RandomScriptureCmd randomScriptureCmd = new RandomScriptureCmd(bible);
            ScriptureLookupCmd scriptureLookupCmd = new ScriptureLookupCmd();

            Dictionary<string, Command> commands = new Dictionary<string, Command>();
            
            commands.Add("dOCmd", displayOptionsCommand);

            commands.Add("r", randomScriptureCmd);
            commands.Add("1", randomScriptureCmd);
            commands.Add("random", randomScriptureCmd);
            commands.Add("Random", randomScriptureCmd);
            
            commands.Add("l", scriptureLookupCmd);
            commands.Add("2", scriptureLookupCmd);
            commands.Add("lookup", scriptureLookupCmd);
            commands.Add("Lookup", scriptureLookupCmd);

            commands.Add("q", quitCommand);
            commands.Add("3", quitCommand);
            commands.Add("quit", quitCommand);
            commands.Add("Quit", quitCommand);


            

            while (!quitCommand.IsQuit()) 
            {
                displayOptionsCommand.Execute();
                string input = Console.ReadLine();

                if (commands.ContainsKey(input)) 
                {
                    commands[input].Execute();
                } 
                else 
                {
                    Console.WriteLine("Invalid command ");
                }
            }
        
        }
    }
}