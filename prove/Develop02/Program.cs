using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            Prompts prompts = new Prompts();

            DisplayOptCmd displayOptionsCommand = new DisplayOptCmd();

            WriteCmd writeCommand = new WriteCmd(prompts, journal);
            DisplayCmd displayCommand = new DisplayCmd(journal);
            LoadCmd loadCommand = new LoadCmd(journal);
            SaveCmd saveCommand = new SaveCmd(journal);
            QuitCmd quitCommand = new QuitCmd();


            Dictionary<string, Command> commands = new Dictionary<string, Command>();

            commands.Add("dOCmd", displayOptionsCommand);

            commands.Add("w", writeCommand);
            commands.Add("1", writeCommand);
            commands.Add("write", writeCommand);
            commands.Add("Write", writeCommand);

            commands.Add("d", displayCommand);
            commands.Add("2", displayCommand);
            commands.Add("display", displayCommand);
            commands.Add("Display", displayCommand);

            commands.Add("l", loadCommand);
            commands.Add("3", loadCommand);
            commands.Add("load", loadCommand);
            commands.Add("Load", loadCommand);

            commands.Add("s", saveCommand);
            commands.Add("4", saveCommand);
            commands.Add("save", saveCommand);
            commands.Add("Save", saveCommand);

            commands.Add("q", quitCommand);
            commands.Add("5", quitCommand);
            commands.Add("quit", quitCommand);
            commands.Add("Quit", quitCommand);
            

            Console.WriteLine("Welcome to the Journal Program!");
            
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