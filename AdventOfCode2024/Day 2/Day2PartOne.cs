using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Day2PartOne
    {
        public int GetFirstAnalysis(List<List<int>> unusualData)
        {

            for (int j = 0; j < unusualData.Count; j++)
            {
                for (int i = 0; i < unusualData[j].Count; i++)
                {
                    //So, a report only counts as safe if both of the following are true:

                    //The levels are either all increasing or all decreasing.
                    //Any two adjacent levels differ by at least one and at most three.
                    List<int> list = unusualData[j];

                    if (list[i] > list[i + 1] && i <= unusualData[j].Count-2)
                    {
                        unusualData.Remove(unusualData[j]);
                    }
                    else if (list[i + 1] - list[i] == 0 || list[i + 1] - list[i] > 3)
                    {
                        unusualData.Remove(unusualData[j]);
                    }

                }
            }

            return unusualData.Count();
        }
    }
}
