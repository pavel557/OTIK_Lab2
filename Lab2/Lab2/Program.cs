using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //string name = "Frankenstein, by Mary Wollstonecraft (Godwin) Shelley.txt";
            //Buffer buffer = new Buffer();
            //List<string> list = new List<string>()
            //{ 
            //    name
            //};

            //buffer.ReadFile(list);
            //Calculation calculation = new Calculation();
            //calculation.CalculationFileLength(buffer);
            //calculation.CalculationNumberEachCharacter(buffer);
            //calculation.CalculationSymbolProbability();
            //calculation.CalculationAmountOfSymbolInformation();
            //calculation.CalculationAmountOfFileInformation(buffer);
            //calculation.Print();

            //2

            //string name = "Frankenstein, by Mary Wollstonecraft (Godwin) Shelley.txt";
            //BufferUnicode buffer = new BufferUnicode();

            //buffer.ReadFile(name);
            //CalculationUnicode calculation = new CalculationUnicode();
            //calculation.CalculationFileLength(buffer);
            //calculation.CalculationNumberEachCharacter(buffer);
            //calculation.CalculationSymbolProbability();
            //calculation.CalculationAmountOfSymbolInformation();
            //calculation.CalculationAmountOfFileInformation(buffer);
            //calculation.Print();


            //3

            //Buffer buffer = new Buffer();
            //List<string> list = new List<string>()
            //{
            //    "myFiles/Frankenstein, by Mary Wollstonecraft (Godwin) Shelley.txt",
            //    "myFiles/Puck of Pook's Hill, by Rudyard Kipling.txt",
            //    "myFiles/Rewards and Fairies, by Rudyard Kipling.txt",
            //    "myFiles/The Mysterious Affair at Styles, by Agatha Christie.txt",
            //    "myFiles/The Secret Adversary, by Agatha Christie.txt",
            //    "myFiles/Three Men in a Boat, by Jerome K. Jerome.txt",
            //    "myFiles/Treasure Island, by Robert Louis Stevenson.txt",
            //    "myFiles/Керниган, Ричи. Язык C.txt",
            //    "myFiles/Лев Николаевич Толстой. Война и мир 1.txt",
            //    "myFiles/Лев Николаевич Толстой. Война и мир 2.txt",
            //    "myFiles/Лев Николаевич Толстой. Война и мир 3.txt",
            //    "myFiles/Лев Николаевич Толстой. Война и мир 4+эпилог.txt",
            //    "myFiles/Льюис Кэрролл. Охота на Снарка — Афонькин.txt",
            //    "myFiles/Льюис Кэрролл. Охота на Снарка — Кружков.txt",
            //    "myFiles/Льюис Кэрролл. Охота на Снарка — Пухов.txt",
            //    "myFiles/Михаил Лермонтов. Герой нашего времени.txt",
            //    "myFiles/Михаил Лермонтов. Герой нашего времени.txt",

            //};

            //buffer.ReadFile(list);
            //Calculation calculation = new Calculation();
            //calculation.CalculationFileLength(buffer);
            //calculation.CalculationNumberEachCharacter(buffer);
            //calculation.CalculationSymbolProbability();
            //calculation.CalculationAmountOfSymbolInformation();
            //calculation.CalculationAmountOfFileInformation(buffer);
            //calculation.Print();

            //4

            Buffer buffer = new Buffer();
            List<string> list = new List<string>()
            {
                "5.txt",

            };

            buffer.ReadFile(list);
            Calculation calculation = new Calculation();
            calculation.CalculationFileLength(buffer);
            calculation.CalculationNumberEachCharacter(buffer);
            calculation.CalculationSymbolProbability();
            calculation.CalculationAmountOfSymbolInformation();
            calculation.CalculationAmountOfFileInformation(buffer);
            calculation.Print();
        }
    }
}
