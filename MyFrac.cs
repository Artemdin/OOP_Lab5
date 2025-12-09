using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OOP_Lab5
{
    internal class MyFrac : IMyNumber<MyFrac>
    {
        private BigInteger nom;
        private BigInteger denom;

        public BigInteger Nom
        {
            get { return nom; }
        }
        public BigInteger Denom
        {
            get { return denom; }
        }

        public MyFrac(BigInteger nom, BigInteger denom)
        {
            this.nom = nom;
            this.denom = denom;
            Normalize();
        }

        private void Normalize()
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);
            nom /= gcd;
            denom /= gcd;

        
            if (denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }
        }

        public MyFrac Add(MyFrac b)
        {
            BigInteger newNom = nom * b.denom + b.nom * denom;
            BigInteger newDen = denom * b.denom;
            return new MyFrac(newNom, newDen);
        }

        public MyFrac Subtract(MyFrac b)
        {
            BigInteger newNom = nom * b.denom - b.nom * denom;
            BigInteger newDen = denom * b.denom;
            return new MyFrac(newNom, newDen);
        }

        public MyFrac Multiply(MyFrac b)
        {
            BigInteger newNom = nom * b.nom;
            BigInteger newDen = denom * b.denom;
            return new MyFrac(newNom, newDen);
        }

        public MyFrac Divide(MyFrac b)
        {
            if (b.nom == 0)
                throw new DivideByZeroException();

            BigInteger newNom = nom * b.denom;
            BigInteger newDen = denom * b.nom;
            return new MyFrac(newNom, newDen);
        }

        public override string ToString()
        {
            return $"{nom}/{denom}";
        }


    }
}
