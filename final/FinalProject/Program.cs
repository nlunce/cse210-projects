using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetSharp;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.CompilerServices;

namespace TwitterBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n<{DateTime.Now}> - Bot Started");

        
            Credentials credentials = new();
            TwitterService service = new(credentials.CustomerKey, credentials.CustomerKeySecret);
            

            DisplayOptCmd displayOptionsCommand = new();
            QuitCmd quitCommand = new();
            WriteTweetCmd writeTweetCmd= new(service);
            

            Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

            commands.Add("dOCmd", displayOptionsCommand);

            commands.Add("t", writeTweetCmd);
            commands.Add("1", writeTweetCmd);
            commands.Add("tweet", writeTweetCmd);
            commands.Add("Tweet", writeTweetCmd);


            commands.Add("q", quitCommand);
            commands.Add("2", quitCommand);
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