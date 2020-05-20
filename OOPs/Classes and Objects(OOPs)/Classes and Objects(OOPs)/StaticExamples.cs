using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{
    public static class StaticExamples
    {
       
        private static int currentVal = 1;

        public static int nextValue()
        {
            currentVal++;
            return currentVal;
        }
    }
}
