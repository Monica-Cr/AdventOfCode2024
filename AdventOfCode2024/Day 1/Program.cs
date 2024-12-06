namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read file
            string filename = "C:\\Github_Projects\\AdventOfCode2024\\AdventOfCode2024\\Day 1\\InputPuzzle1.txt";

            List<int> columnOne = new List<int>();
            List<int> columnTwo = new List<int>();

            using StreamReader sr = new StreamReader(filename);
            string line;


            while ((line = sr.ReadLine()) != null)
            {
                string[] values = line.Split(' ');

                columnOne.Add(int.Parse(values[0].Trim()));
                columnTwo.Add(int.Parse(values[3].Trim()));
            }

            // Puzzle 1
            PartOne partOne = new PartOne();
            int result1 = partOne.GetFirstAnalysis(columnOne, columnTwo);
            Console.WriteLine($"The result of the first analysis is: {result1}");

            // Puzzle 2
            PartTwo partTwo = new PartTwo();
            int result2 = partTwo.GetSecondAnalysis(columnOne, columnTwo);
            Console.WriteLine($"The result of the second analysis is: {result2}");

        }
    }
}
