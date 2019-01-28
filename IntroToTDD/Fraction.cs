using System;

namespace IntroToTDD
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction() { }

        public Fraction(int numerator, int denominator = 1)
        {
            if (denominator == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(denominator), "The denominator cannot be zero.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction frac2)
        {
            var frac1 = new Fraction(this.numerator, this.denominator);

            if (frac2.denominator != frac1.denominator)
            {
                if(frac1.denominator > frac2.denominator)
                {
                    (frac1, frac2) = FindCommonDenominator(frac1, frac2);
                }
                else
                {
                    (frac1, frac2) = FindCommonDenominator(frac2, frac1);
                }
            }

            var numerator = frac2.numerator + frac1.numerator;
            var denominator = frac2.denominator;

            return new Fraction(numerator, denominator);//.Reduce();
        }

        private (Fraction, Fraction) FindCommonDenominator(Fraction frac1, Fraction frac2)
        {
            Fraction newFrac1 = null;
            Fraction newFrac2 = null;

            if (frac1.denominator % frac2.denominator == 0)
            {
                var factor = frac1.denominator / frac2.denominator;
                newFrac1 = frac1;
                newFrac2 = new Fraction(frac2.numerator * factor, frac2.denominator * factor);
            }
            else
            {
                var newDenominator = frac1.denominator * frac2.denominator;
                newFrac1 = new Fraction(frac1.numerator * frac2.denominator, newDenominator);
                newFrac2 = new Fraction(frac2.numerator * frac1.denominator, newDenominator);
            }

            return (newFrac1, newFrac2);
        }

        private Fraction Reduce()
        {
            return new Fraction();
        }

        public bool Equals(Fraction fraction)
        {
            return fraction.ToString() == this.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Fraction) && ((Fraction)obj).ToString() == this.ToString();
        }

        public static bool operator ==(Fraction frac1, Fraction frac2)
        {
            if (ReferenceEquals(frac1, frac2))
            {
                return true;
            }

            if (ReferenceEquals(frac1, null) || ReferenceEquals(frac2, null))
            {
                return false;
            }

            return (frac1.numerator == frac2.numerator && frac1.denominator == frac2.denominator);
        }

        public static bool operator !=(Fraction frac1, Fraction frac2)
        {
            return !(frac1 == frac2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hasCode = numerator.GetHashCode();
                hasCode = (hasCode * 397) ^ denominator.GetHashCode();
                return hasCode;
            }
        }

        public override string ToString()
        {
            return this.numerator + "/" + this.denominator;
        }
    }
}
