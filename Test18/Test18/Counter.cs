using System;
using System.Collections.Generic;
using System.Text;

namespace Primitives
{
    class Counter
    {
        int i=0;
        public Counter(int n = 0)
        {
            i = n;
        }

        public void add(int n = 1)
        {
            i += n;
        }

        public void subtract(int n = 1)
        {
            i -= n;
        }

        public int getCount()
        {
            return i;
        }
    }
}
