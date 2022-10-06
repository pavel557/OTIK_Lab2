using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab2
{
    class CalculationUnicode
    {
        public int fileLength;
        public SortedDictionary<char, int> numberEachCharacter;
        public SortedDictionary<char, float> symbolProbability;
        public SortedDictionary<char, double> amountOfSymbolInformation;
        public double amountOfFileInformation;

        public CalculationUnicode()
        {
            numberEachCharacter = new SortedDictionary<char, int>();
            symbolProbability = new SortedDictionary<char, float>();
            amountOfSymbolInformation = new SortedDictionary<char, double>();
            amountOfFileInformation = 0;
        }

        public void CalculationFileLength(BufferUnicode buffer)
        {
            fileLength = buffer.file.Length;
        }

        public void CalculationNumberEachCharacter(BufferUnicode buffer)
        {
            foreach (char b in buffer.file)
            {
                if (!numberEachCharacter.ContainsKey(b))
                {
                    numberEachCharacter.Add(b, 1);
                }
                else
                {
                    numberEachCharacter[b]++;
                }
            }
        }

        public void CalculationSymbolProbability()
        {
            foreach (var c in numberEachCharacter)
            {
                symbolProbability.Add(c.Key, (float)c.Value / (float)fileLength);
            }
        }

        public void CalculationAmountOfSymbolInformation()
        {
            foreach (var c in symbolProbability)
            {
                amountOfSymbolInformation.Add(c.Key, -Math.Log(c.Value));
            }
        }

        public void CalculationAmountOfFileInformation(BufferUnicode buffer)
        {
            foreach (var c in buffer.file)
            {
                amountOfFileInformation += amountOfSymbolInformation[c];
            }
        }

        public void Print()
        {
            Console.WriteLine("Длина файла:" + fileLength);

            Console.WriteLine("Количество символов");

            foreach (var c in numberEachCharacter)
            {
                Console.WriteLine("Символ: " + c.Key + " Количество: " + c.Value);
            }

            Console.WriteLine("Частота символов");

            foreach (var c in symbolProbability)
            {
                Console.WriteLine("Символ: " + c.Key + " Вероятность: " + c.Value);
            }

            Console.WriteLine("Количество информации в символе");

            foreach (var c in amountOfSymbolInformation)
            {
                Console.WriteLine("Символ: " + c.Key + " Количество информации: " + c.Value);
            }

            Console.WriteLine("Сортитовка по частоте");

            Console.WriteLine("Количество символов");

            foreach (var c in numberEachCharacter.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine("Символ: " + c.Key + " Количество: " + c.Value);
            }

            Console.WriteLine("Частота символов");

            foreach (var c in symbolProbability.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine("Символ: " + c.Key + " Вероятность: " + c.Value);
            }

            Console.WriteLine("Количество информации в символе");

            foreach (var c in amountOfSymbolInformation.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine("Символ: " + c.Key + " Количество информации: " + c.Value);
            }

            Console.WriteLine("Количество информации в файле");
            Console.WriteLine(amountOfFileInformation);
        }
    }
}
