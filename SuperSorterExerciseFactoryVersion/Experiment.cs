using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class Experiment
    {
        private List<ISorter> sorters;
        private List<IArray> arrays;
        private SuperFactory superF;

        public Experiment(SuperFactory superFactory)
        {
            superF = superFactory;
            sorters = superF.sf.FactoryMethod();
            arrays = superF.af.FactoryMethod();

            foreach (IArray array in arrays)
            {
                if (array != null)
                {
                    foreach (ISorter sorter in sorters)
                    {
                        if (sorter != null)
                        {
                            Console.WriteLine($"Now testing {sorter.GetType()} with array {array.GetType()}");
                            Console.WriteLine($"Sorting the array took: {sorter.Sort(array.GetArray())} milliseconds");
                        }
                    }
                }
            }
        }

    }
}
