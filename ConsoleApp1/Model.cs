using System;
using System.Linq;

namespace ConsoleApp1
{
  public class Model
    {
        private string toConvert;

        public Model()
        {

        }

        public Model(string toConvert)
        {
            this.toConvert = toConvert;
        }

        public string ToConvert { get => toConvert; set => toConvert = value; }

        public string LowerToUpper()
        {
            string temp = "";
            for (int i = 0; i < toConvert.Count(); i++)
            {
                char letter = toConvert[i];
                if (letter >= 'a' && letter <= 'z')
                {
                    letter = (char)(letter - 32);
                }
                temp += letter;
            }
            return temp;
        }
    }
}