using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class PartOne
    {
        public int GetFirstAnalysis(List<int> columnOne, List<int> columnTwo)
        {
            int difference = 0;
            

            columnOne.Sort();
            columnTwo.Sort();

            for (int i = 0; i < columnOne.Count; i++)
            {
                int numberColOne = columnOne[i];
                int numberColTwo = columnTwo[i];

                if (numberColOne > numberColTwo)
                {
                    difference += numberColOne - numberColTwo;
                }
                else
                {
                    difference += numberColTwo - numberColOne;
                }
            }

            return difference;
        }
    }
}
