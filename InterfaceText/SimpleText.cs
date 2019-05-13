using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InterfaceText
{
    public class SimpleText : IContent
    {
        List<string> sentences = new List<string>();

        public SimpleText()
        {
        }

        

        public int CountWords()
        {
            int length = 0;
            foreach (string t in sentences)
            {
                string[] words = t.Split(" ");
                length += words.Length;
            }

            return length;

        }


        public string GetLengthiestWord()
        {
            throw new NotImplementedException();
        }

        public bool LoadText(string filename)
        {
            try
            {
                string text = System.IO.File.ReadAllText(filename);
                string[] content = text.Split("\n");
                foreach (string t in content)
                {
                    sentences.Add(t);
                    //  Console.WriteLine(t);
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool SaveText(string filename)
        {
            throw new NotImplementedException();
        }
    }


}
