using System;

namespace ConsoleApp1

{
    public class Vue
    {
        private string message;

        public Vue()
        {
        }

        public Vue(string message)
        {
            this.Message = message;
        }

        public string Message { get => message; set => message = value; }

        public void AffichageMessage()
        {
            Console.WriteLine("Result: " + message);
        }
    }
}
