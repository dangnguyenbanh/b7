using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Tinhtoan
    {
        private float A, B;

        public float b
        {
            get { return B; }
            set { B = value; }
        }
        public float a
        {
            get { return A; }
            set { A = value; }
        }
        public Tinhtoan()
        {
            a = b = 0;
        }
        public Tinhtoan(float a, float b)
        {
            A = a;
            B = b;
        }
        public float Cong()
        {
            return A + B;
        }
        public float Tru()
        {
            return A - B;
        }
        public float Nhan()
        {
            return A * B;
        }
        public float Chia()
        {
            return A / B;
        }
    }
       
     
}
