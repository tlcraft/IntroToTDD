using System;

namespace IntroToTDD
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction() { }

        public Fraction(int numerator, int denomiator = 1)
        {
            this.numerator = numerator;
            this.denominator = denomiator;
        }

        public Fraction Add(Fraction a)
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
