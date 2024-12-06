using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using System;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read file
            string filename = "C:\\Github_Projects\\AdventOfCode2024\\AdventOfCode2024\\Day 2\\InputPuzzle2.txt";

            List<List<int>> unusualData = new List<List<int>>();

            using StreamReader sr = new StreamReader(filename);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] extractedValues = line.Split(' ');

                List<int> values = new List<int>();
                foreach (string value in extractedValues)
                {
                    values.Add(int.Parse(value));
                    values.Sort();
                }

                unusualData.Add(values);
            }

            // Part One
            Day2PartOne partOne = new Day2PartOne();
            int result = partOne.GetFirstAnalysis(unusualData);
            Console.WriteLine(result);
        }
    }
}
