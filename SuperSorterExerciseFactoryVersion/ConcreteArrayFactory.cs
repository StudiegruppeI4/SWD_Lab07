using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class ConcreteArrayFactory : ArrayFactory
    {
        private IArray FewUniques()
        {
            return null;
        }

        private IArray NearlySorted()
        {
            return null;
        }

        private IArray GenerateRandomArray()
        {
            return new RandomArray();
        }

        private IArray ReverseOrder()
        {
            return new ReverseOrderArray();
        }

        public List<IArray> FactoryMethod()
        {
            return new List<IArray>
            {
                FewUniques(),
                NearlySorted(),
                GenerateRandomArray(),
                ReverseOrder()
            };
        }
    }
}
