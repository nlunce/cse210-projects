using System;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Command command = new Command();
            Console.WriteLine("\r\nWelcome to the journal program!");
            
            while(!command._quit)
            {
            command.DisplayOptions();
            command.GetInput();
            }


        }
    }
}