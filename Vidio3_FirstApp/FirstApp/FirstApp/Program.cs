using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ctrl+F5  runs the program and shows the output window
 References: needed dlls  and libraries 
 solution:   project files
 App.config : project settings like netframwork version
 */

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World");
        }
    }
}
