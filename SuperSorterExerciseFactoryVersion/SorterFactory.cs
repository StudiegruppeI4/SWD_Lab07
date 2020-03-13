using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    public interface SorterFactory
    {
        List<ISorter> FactoryMethod();
    }
}
