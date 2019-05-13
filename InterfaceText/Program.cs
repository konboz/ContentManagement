using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InterfaceText
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"randomtext.txt";


            var text1 = new SimpleText();
            if (text1.LoadText(filename))
            {
                Console.WriteLine("File found");
                Console.WriteLine(text1.CountWords());
            }
            else
            {
                Console.WriteLine("File not found");
            }
            

            Console.ReadLine();
            
        }
    }
}
