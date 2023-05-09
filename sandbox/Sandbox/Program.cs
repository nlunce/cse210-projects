using System;
using System.Collections.Generic;

// The Receiver class
class Calculator {
    private int result = 0;
    
    public void Add(int value) {
        result += value;
        Console.WriteLine("Added " + value + ", Result = " + result);
    }
    
    public void Subtract(int value) {
        result -= value;
        Console.WriteLine("Subtracted " + value + ", Result = " + result);
    }
    
    public void Multiply(int value) {
        result *= value;
        Console.WriteLine("Multiplied by " + value + ", Result = " + result);
    }
    
    public void Divide(int value) {
        result /= value;
        Console.WriteLine("Divided by " + value + ", Result = " + result);
    }
}

// The Command interface
interface ICommand {
    void Execute();
}

// Concrete Command classes
class AddCommand : ICommand {
    private Calculator calculator;
    private int value;
    
    public AddCommand(Calculator calculator, int value) {
        this.calculator = calculator;
        this.value = value;
    }
    
    public void Execute() {
        calculator.Add(value);
    }
}

class SubtractCommand : ICommand {
    private Calculator calculator;
    private int value;
    
    public SubtractCommand(Calculator calculator, int value) {
        this.calculator = calculator;
        this.value = value;
    }
    
    public void Execute() {
        calculator.Subtract(value);
    }
}

class MultiplyCommand : ICommand {
    private Calculator calculator;
    private int value;
    
    public MultiplyCommand(Calculator calculator, int value) {
        this.calculator = calculator;
        this.value = value;
    }
    
    public void Execute() {
        calculator.Multiply(value);
    }
}

class DivideCommand : ICommand {
    private Calculator calculator;
    private int value;
    
    public DivideCommand(Calculator calculator, int value) {
        this.calculator = calculator;
        this.value = value;
    }
    
    public void Execute() {
        calculator.Divide(value);
    }
}

// The Invoker class
class Menu {
    private Dictionary<char, ICommand> commands = new Dictionary<char, ICommand>();
    
    public void SetCommand(char key, ICommand command) {
        commands[key] = command;
    }
    
    public void Run() {
        Calculator calculator = new Calculator();
        
        while (true) {
            Console.WriteLine("Enter a command:");
            Console.WriteLine("(a)dd (s)ubtract (m)ultiply (d)ivide (q)uit");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            if (key == 'q') {
                break;
            }
            
            if (commands.ContainsKey(key)) {
                Console.WriteLine("Enter a value:");
                int value = int.Parse(Console.ReadLine());
                
                ICommand command = commands[key];
                command.Execute();
            } else {
                Console.WriteLine("Invalid command");
            }
        }
    }
}

// Client code
class Program 
{
    static void Main(string[] args) {
        Menu menu = new Menu();
        Calculator calculator = new Calculator();
        
        // Create command objects and set them to the menu
        ICommand addCommand = new AddCommand(calculator, 0);
        ICommand subtractCommand = new SubtractCommand(calculator, 0);
        ICommand multiplyCommand = new MultiplyCommand(calculator, 0);
        ICommand divideCommand = new DivideCommand(calculator, 0);
        menu.SetCommand('a', addCommand);
        menu.SetCommand('s', subtractCommand);
        menu.SetCommand('m', multiplyCommand);
       
    }
}