using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class ReverseOrderArray : IArray
    {

        public int[] GetArray()
        {
            int[] array = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            return array;
        }
    }
}
