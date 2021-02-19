using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class GeneratorPASS
    {
        public string sd { get; set; }
        public void GenerateNew(int length)
        {
            
            string Alphabet = "abcdefghijklmnopqrstuvwxyz_-,./]!`@#%ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rd = new Random();
            StringBuilder sb = new StringBuilder(length - 1);
            int Position = 0;

            for (int i = 0; i < length; i++)
            {
                Position = rd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);
                
            }
            sd = sb.ToString();
            
        }
    }
}
