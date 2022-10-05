using System;
using System.IO;
using System.Text;

namespace Lab2
{
    class Buffer
    {
        public byte[] file;

        public void ReadFile(string path)
        {
            using (FileStream fstream = File.OpenRead(path))
            {
                // выделяем массив для считывания данных из файла
                file = new byte[fstream.Length];
                // считываем данные

                fstream.Read(file);
            }
        }
    }
}
