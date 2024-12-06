using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class PartTwo
    {
        public int GetSecondAnalysis(List<int> columnOne, List<int> columnTwo)
        {
            int similarityScore = 0;

            foreach (int number in columnOne)
            {
                int appearence = columnTwo.Where(x => x == number).Count();

                similarityScore += appearence * number;
            }

            return similarityScore;
        }
    }
}
