using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceText
{
    public interface IContent
    {
        int CountWords();
        string GetLengthiestWord();
        bool LoadText(string filename);
        bool SaveText(string filename);
    }
}
