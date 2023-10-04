using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaptaplop4._2
{
    class Tính
    {
        private float A, B, C;
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
        public float c
        {
            get { return C; }
            set { C = value; }
        }
        public Tính()
        {
            a = b = c = 0;
        }
        public Tính(float a, float b,float c)
        {
            A = a;
            B = b;
            C = c;
        }
        public string Tinhphuongtrinhb1(double a, double b)
        {
            if(a==0)
            {
                return "không phải là phương trình bậc nhất";
            }
            double x = -b / a;
            return "nghiệm của phương trình : x=" + x;
        }
        public string Tinhphuongtrinhb2(double a,double b,double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "Phương trình không có nghiệm thực.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return "Nghiệm kép của phương trình: x1 = x2 = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Nghiệm của phương trình: x1 = " + x1 + ", x2 = " + x2;
            }

        }


    }
}
