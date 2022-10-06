using System;
using System.IO;
using System.Text;

namespace Lab2
{
    class BufferUnicode
    {
        public string file;

        public void ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            file = sr.ReadToEnd();
        }
    }
}
