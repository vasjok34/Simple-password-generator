using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Generator
{
    class AddingPass
    {
        public void write(params string[] text)
        {
            string WritePath = @"C:\Users\Lenovo\source\repos\Generator\paswords.txt";
            using (StreamWriter sw = new StreamWriter(WritePath, true, Encoding.Default))
            {
                
                sw.WriteLine(string.Join("- is your password for - ",text));
                
            }
        }
    }
}
