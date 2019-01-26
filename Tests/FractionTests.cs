using IntroToTDD;
using Xunit;

namespace Tests
{
    public class FractionTests
    {
        [Fact]
        public void Fraction_Add_SevenFourths_FourFifths()
        {
            Fraction sevenFourths = new Fraction(7, 4);
            Fraction fourFifths = new Fraction(4, 5);

            Assert.True(sevenFourths.Add(fourFifths) == new Fraction(47, 15));
        }

        [Fact]
        public void Fraction_Add_WholeNumbers()
        {
            Fraction four = new Fraction(4);
            Fraction nine = new Fraction(9);

            Assert.True(four.Add(nine) == new Fraction(13));
        }

        [Fact]
        public void Fraction_ToString()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Assert.True(oneHalf.ToString() == "1/2");
        }

        [Fact]
        public void Fraction_Equals()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction anotherHalf = new Fraction(1, 2);
            Assert.True(oneHalf.Equals(anotherHalf));
        }

        [Fact]
        public void Fraction_NotEquals()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneThird = new Fraction(1, 3);
            Assert.True(!oneHalf.Equals(oneThird));
        }

        [Fact]
        public void Fraction_Equality_EqualTo_Operator()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction anotherHalf = new Fraction(1, 2);
            Assert.True(oneHalf == anotherHalf);
        }

        [Fact]
        public void Fraction_Equality_NotEqualTo_Operator()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneThird = new Fraction(1, 3);
            Assert.True(oneHalf != oneThird);
        }

        [Fact]
        public void Fraction_HashCode()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction anotherHalf = new Fraction(1, 2);
            Assert.True(oneHalf.GetHashCode() == anotherHalf.GetHashCode());
        }

        [Fact]
        public void Fraction_HashCode_NotEqualTo()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneThird = new Fraction(1, 3);
            Assert.True(oneHalf.GetHashCode() != oneThird.GetHashCode());
        }

        /*
        
        Condidtions

        Lowest Terms: 4/6 -> 2/3
        Improper: 7/5 NOT 1 2/5
        Don't add to floating point numbers
        Allow ability to add to whole numbers

        */

        /*
        
        Test List

        5 + 1/4 = 21/4
        1/2 + 1/3 = 5/6
        0 + 0 = 0
        1 + 2 = 3
        1/2 + 1/2 = 1
        10/5 + 20/10 = 4
        1/4 + 7/8 = 9/8

         */
    }
}
