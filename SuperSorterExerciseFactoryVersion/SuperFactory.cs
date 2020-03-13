using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSorterExerciseFactoryVersion
{
    class SuperFactory
    {

        public ArrayFactory af { get; set; }
        public SorterFactory sf { get; set; }

        public SuperFactory(ArrayFactory af, SorterFactory sf)
        {
            this.af = af;
            this.sf = sf;
        }
   }
}
