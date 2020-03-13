using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class ConcreteSorterFactory : SorterFactory
    {
        private ISorter CreateSorterBubble()
        {
            return new BubbleSorter();
        }

        private ISorter CreateSorterInsertion()
        {
            return null;
        }

        private ISorter CreateSorterQuick()
        {
            return null;
        }

        private ISorter CreateSorterShell()
        {
            return null;
        }

        public List<ISorter> FactoryMethod()
        {
            return new List<ISorter>
            {
                CreateSorterBubble(),
                CreateSorterInsertion(),
                CreateSorterQuick(),
                CreateSorterShell()
            };
        }
    }
}
