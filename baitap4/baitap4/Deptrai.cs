using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class Deptrai  <T>
    {
        T x;
        public Deptrai (T x) 
        {
            this.x = x; 
        }
        public T get()
        {
            return x;
        }

    }
}
