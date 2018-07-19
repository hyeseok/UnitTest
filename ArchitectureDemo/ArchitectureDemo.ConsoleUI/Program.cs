using ArchitectureDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchitectureDemo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Greeting greeting = new Greeting();
            string text = greeting.SayHello(name);

            Console.WriteLine(text);
        }
    }

    
}
