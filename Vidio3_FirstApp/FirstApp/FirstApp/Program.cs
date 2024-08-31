using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ctrl+F5 (build) runs the program and shows the output window or add  Console.ReadKey(); at end of your code to see the output then use F5 (debug)to run the code
 ctrl+K+D  align your code
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
            int A = 3;  // A Simple data type
            int b = 7;  // b Simple data type
            int c;
            string a = Convert.ToString(A);
            string num1 = "23";

            int num = Convert.ToInt32(num1);
            bool IsActive = Convert.ToBoolean("True");

            Console.ForegroundColor = ConsoleColor.Yellow; // Console complex data type
            Console.WriteLine(b);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("A: "+ A);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
