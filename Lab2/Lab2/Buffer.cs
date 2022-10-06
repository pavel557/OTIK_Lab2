using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Lab2
{
    class Buffer
    {
        public List<byte> file;

        public void ReadFile(List<string> paths)
        {
            file = new List<byte>();
            foreach (string path in paths)
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    byte[] b = new byte[fstream.Length];
                    fstream.Read(b);
                    file.AddRange(b);
                }
            }

        }
    }
}
