using System;
using System.Collections.Generic;

namespace Develop02{
public class Prompts{
    
    Random _random = new Random();
    public List<string> _prompts = new List<string>()
    {
        "What did you do today? ",
        "What was the strongest feeling you felt today? ",
        "Name five things you are thankful for. ",
        "What is something you want to do tomorrow? ",
        "How are you feeling? ",
        "Create a list of short term goals. "
        
    };

    public string GetRandomPrompt()
    {
        int index = this._random.Next(_prompts.Count);
        Console.Write($"{this._prompts[index]}\n> ");
        return this._prompts[index];

    }
    public Prompts()
    {
        
    }
}
}