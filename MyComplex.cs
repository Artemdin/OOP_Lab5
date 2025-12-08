using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    internal class MyComplex : IMyNumber<MyComplex>
    {
        private double re;
        private double im;

 
        public double Re
        {
            get
            {
                return re;
            }
        }
        public double Im
        {
            get
            {
                return im;
            }
        }
        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public MyComplex Add(MyComplex b)
        {
            double newRe = re + b.re;
            double newIm = im + b.im;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Subtract(MyComplex b)
        {
            double newRe = re - b.re;
            double newIm = im - b.im;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Multiply(MyComplex b)
        {
            double newRe = re * b.re - im * b.im;
            double newIm = re * b.im + im * b.re;
            return new MyComplex(newRe, newIm);
        }

        public MyComplex Divide(MyComplex b)
        {
            double divisor = b.re * b.re + b.im * b.im;

            if (divisor == 0)
                throw new DivideByZeroException();

            double newRe = (re * b.re + im * b.im) / divisor;
            double newIm = (im * b.re - re * b.im) / divisor;
            return new MyComplex(newRe, newIm);
        }

        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
}
