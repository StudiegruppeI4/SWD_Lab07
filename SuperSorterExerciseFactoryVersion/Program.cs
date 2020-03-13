using System;

namespace SuperSorterExerciseFactoryVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Experiment experiment = new Experiment(new SuperFactory(new ConcreteArrayFactory(), new ConcreteSorterFactory()));
        }
    }
}
