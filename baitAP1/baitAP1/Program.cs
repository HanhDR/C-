using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    class Hinhtron
    {
        private double r;
        public Hinhtron(double r)
        {
            this.r = r;
        }
        public double dienTich()
        {
            return 3.14 * r * r;


        }
        class Hinhtru : Hinhtron
        {
            double d;
            public Hinhtru(double r, double d) : base(r)
            {
                this.d = d;
            }
            public double thetich()
            {
                return d * dienTich();
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Hinhtru d = new Hinhtru(6, 10);
                Console.WriteLine("dien tich hinh tron {0}", d.dienTich());
                Console.WriteLine("the tich hinh tru {0}", d.thetich());
            }
        }
    }
}