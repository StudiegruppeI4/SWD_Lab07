using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SuperSorterExerciseFactoryVersion
{
    class BubbleSorter : ISorter
    {
        public long Sort(int[] array)
        {
            int[] tmp = array;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int temp;

            for (int j = 0; j <= tmp.Length - 2; j++)
            {
                for (int i = 0; i <= tmp.Length - 2; i++)
                {
                    if (tmp[i] > tmp[i + 1])
                    {
                        temp = tmp[i + 1];
                        tmp[i + 1] = tmp[i];
                        tmp[i] = temp;
                    }
                }
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
