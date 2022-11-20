using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1

{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            //Fonction2();

            Vuemodel vuemodel = new Vuemodel();
            vuemodel.SaisieText();
            vuemodel.CheckText();
            vuemodel.CheckText();

            string line = Console.ReadLine();

        }

        public static void Fonction1()
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

        public static void Fonction2()
        {
            //wait user to enter a caracter line
            Console.WriteLine("please enter a caracter line: ");
            //user enter what he wants
            string line = Console.ReadLine();
            Console.WriteLine("what you entered is: " + line);
            //upcase these caracters
            string result = "";
            for(int i = 0; i < line.Count(); i++)   
            {
                char letter = line[i];
                if (letter >= 'a' && letter <= 'z')
                {
                    letter = (char)(letter - 32);
                }
                result += letter;
            }
            
            Console.WriteLine("result: " + result);
        }
    }
}
