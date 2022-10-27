using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class HCN
    {
        private double d;
        private double r;

      


        public HCN(double d, double r)
        {
            this.d = d;
            this.r = r;

        }

        public double dienTich()
        {
            return d * r;


        }
        public double chuvi()
        {
            return (d + r) * 2;
        }
    }
}
