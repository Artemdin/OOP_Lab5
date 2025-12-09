using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    internal class MyComplex : IMyNumber<MyComplex>
    {
        private double real;
        private double imagi;

 
        public double Re
        {
            get
            {
                return real;
            }
        }
        public double Im
        {
            get
            {
                return imagi;
            }
        }
        public MyComplex(double real, double imagi)
        {
            this.real = real;
            this.imagi = imagi;
        }

        public MyComplex Add(MyComplex b)
        {
            double newRe = real + b.real;
            double newIm = imagi + b.imagi;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Subtract(MyComplex b)
        {
            double newRe = real - b.real;
            double newIm = imagi - b.imagi;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Multiply(MyComplex b)
        {
            double newRe = real * b.real - imagi * b.imagi;
            double newIm = real * b.imagi + imagi * b.real;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Divide(MyComplex b)
        {
            double divisor = b.real * b.real + b.imagi * b.imagi;

            if (divisor == 0)
                throw new DivideByZeroException();

            double newRe = (real * b.real + imagi * b.imagi) / divisor;
            double newIm = (imagi * b.real - real * b.imagi) / divisor;
            return new MyComplex(newRe, newIm);
        }

        public override string ToString()
        {
            if (imagi >= 0)
                return $"{real}+{imagi}i";
            else
                return $"{real}{imagi}i"; 
        }
    }
}
