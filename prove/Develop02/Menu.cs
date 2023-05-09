using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Menu
    {
        
        public bool _quit = false;

        

        Journal journal = new Journal();
        Prompts prompts = new Prompts();
        Command command = new Command();

        public Menu(){
            
            Console.WriteLine("\r\nWelcome to the journal program!"); 

            
        }

        
        

        

        

    }
}
