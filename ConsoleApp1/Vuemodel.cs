using System;

namespace ConsoleApp1
{
    public class Vuemodel
    {
        private Vue vue;
        private Model model;
        private string message;

        public Vuemodel()
        {

        }

        public void SaisieText()
        {
            //wait user to enter a message
            Console.WriteLine("please enter a caracter line: ");
            //user enter what he wants
            this.message = Console.ReadLine();

            //set the attribute
            this.model = new Model(message);
            string result = model.LowerToUpper();
            this.vue = new Vue(result);
        }

        public void CheckText()
        {
            //user check his message
            vue.AffichageMessage();
        }
    }
}