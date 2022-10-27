

using System;

namespace baitap2
{
    class Hinhchunhat
    {
        private int a ;  
        private int b;
        

   

        public Hinhchunhat(int a, int b)
        {
            this.a = a;
            this.b = b;
          
        }

        public int dienTich()
        {
            return a * b;


        }
        public int chuvi()
        {
            return (a + b) * 2;
        }
        class Hinhhop : Hinhchunhat
        {
            int d;
            public Hinhhop(int a, int b,int d) : base(a,b)
            {
                this.d = d;
            }
            public int thetich()
            {
                return d * dienTich();
            }
            public int xungquanh()
            {
                return 2*d*(a+b);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Hinhhop d = new Hinhhop(3,4,5);
                Console.WriteLine("dien tich hinh chu nhat{0}", d.dienTich());
                Console.WriteLine("chu vi hinh chu nhat {0}", d.chuvi());
                Console.WriteLine("the tich hinh hop {0}", d.thetich());
                Console.WriteLine("dien tich xung quanh  hinh hop {0}", d.xungquanh());
            }
        }
    }
}
