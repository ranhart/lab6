using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Fraction : ICloneable
    {
        private int _numerator;
        private int _denominator;
        private double _real;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            if (denominator <= 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю или быть меньше нуля");
            }
            else { _denominator = denominator; }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numf3;
            int denomf3;
            if (f1._denominator == f2._denominator)
            {
                numf3 = f1._numerator + f2._numerator;
                denomf3 = f1._denominator + f2._denominator;
            }
            else
            {
                denomf3 = f1._numerator * f2._denominator;
                numf3 = (f1._numerator * f2._denominator) + (f2._numerator * f1._denominator);
            }
            return new Fraction(numf3, denomf3);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numf3;
            int denomf3;
            if (f1._denominator == f2._denominator)
            {
                numf3 = f1._numerator - f2._numerator;
                denomf3 = f1._denominator - f2._denominator;
            }
            else
            {
                denomf3 = f1._numerator * f2._denominator;
                numf3 = (f1._numerator * f2._denominator) - (f2._numerator * f1._denominator);
            }
            return new Fraction(numf3, denomf3);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numf3 = f1._numerator * f2._numerator;
            int denomf3 = f1._denominator * f2._denominator;
            return new Fraction(numf3, denomf3);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int numf3 = f1._numerator * f2._denominator;
            int denomf3 = f1._denominator * f2._numerator;
            return new Fraction(numf3, denomf3);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction f1 = obj as Fraction;
                return f1._numerator == _numerator && f1._denominator == _denominator;
            }
            return false;
        }

        public Fraction Clone()
        {
            return new Fraction(_numerator, _denominator);
        }

        public double GetReal()
        {
            _real = (double)_numerator / _denominator;
            return _real;
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }
    }
}
