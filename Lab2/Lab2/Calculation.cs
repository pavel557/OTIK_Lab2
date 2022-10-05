using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab2
{
    class Calculation
    {
        public int fileLength;
        public SortedDictionary<byte, int> numberEachCharacter;
        public SortedDictionary<byte, float> symbolProbability;
        public SortedDictionary<byte, double> amountOfSymbolInformation;
        public double amountOfFileInformation;

        public Calculation()
        {
            numberEachCharacter = new SortedDictionary<byte, int>();
            symbolProbability = new SortedDictionary<byte, float>();
            amountOfSymbolInformation = new SortedDictionary<byte, double>();
            amountOfFileInformation = 0;
        }

        public void CalculationFileLength(Buffer buffer)
        {
            fileLength = buffer.file.Length;
        }

        public void CalculationNumberEachCharacter(Buffer buffer)
        {
            foreach (byte b in buffer.file)
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

        public void CalculationAmountOfFileInformation(Buffer buffer)
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
