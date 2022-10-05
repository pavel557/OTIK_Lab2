using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Frankenstein, by Mary Wollstonecraft (Godwin) Shelley.txt";
            Buffer buffer = new Buffer();
            buffer.ReadFile(name);
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
