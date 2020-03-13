using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    interface ArrayFactory
    {
       public List<IArray> FactoryMethod();
    }
}
