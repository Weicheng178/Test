using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            fonction();
        }

        public static void fonction()
        {
            //wait user to enter a caracter line
            Console.WriteLine("please enter a caracter line: ");
            //user enter what he wants
            string line = Console.ReadLine();
            Console.WriteLine("what you entered is: " + line);
            //upcase these caracters
            line = line.ToUpper();
            Console.WriteLine("the result is: " + line);
        }
    }
}
