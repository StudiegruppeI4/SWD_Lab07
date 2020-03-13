using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class RandomArray : IArray
    {
        private int _size;
        private int _max;
        private int _seed;

        public RandomArray(int size = 1000, int max = 100, int seed = 1)
        {
            _seed = seed;
            _size = size;
            _max = max;
        }

        public int[] GetArray()
        {
            Random random = new Random(_seed);
            int[] array = new int[_size];
            for (var i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(0, _max);
            }
            return array;
        }
    }
}
