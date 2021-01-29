using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IParser
    {
        void Start(string inputFile, string jsonIgnoreFilePath);
    }
}
