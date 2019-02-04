using IntroToTDD;
using Xunit;

namespace Tests
{
    public class FractionTests
    {
        [Fact]
        public void Fraction_Add_TenFifths_TwentyTens()
        {
            Fraction tenFifths = new Fraction(10, 5);
            Fraction twentyTens = new Fraction(20, 10);

            Assert.True(tenFifths.Add(twentyTens) == new Fraction(4));
        }
        
        [Fact]
        public void Fraction_Add_OneHalf()
        {
            Fraction oneHalf = new Fraction(1, 2);

            Assert.True(oneHalf.Add(oneHalf) == new Fraction(1));
        }

        [Fact]
        public void Fraction_Add_OneFourth_SevenEighths()
        {
            Fraction oneFourth = new Fraction(1, 4);
            Fraction sevenEighths = new Fraction(7, 8);

            Assert.True(oneFourth.Add(sevenEighths) == new Fraction(9, 8));
        }

        [Fact]
        public void Fraction_Add_One_Two()
        {
            Fraction one = new Fraction(1);
            Fraction two = new Fraction(2);

            Assert.True(one.Add(two) == new Fraction(3));
        }

        [Fact]
        public void Fraction_Add_Five_OneFourth()
        {
            Fraction five = new Fraction(5);
            Fraction oneFourth = new Fraction(1, 4);

            Assert.True(five.Add(oneFourth) == new Fraction(21, 4));
        }

        [Fact]
        public void Fraction_Add_OneHalf_OneThird()
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneThird = new Fraction(1, 3);

            Assert.True(oneHalf.Add(oneThird) == new Fraction(5, 6));
        }

        [Fact]
        public void Fraction_Add_Zero()
        {
            Fraction zero = new Fraction(0);

            Assert.True(zero.Add(zero) == new Fraction(0));
        }

        [Fact]
        public void Fraction_Add_SevenFourths_FourFifths()
        {
            Fraction sevenFourths = new Fraction(7, 4);
            Fraction fourFifths = new Fraction(4, 5);

            Assert.True(sevenFourths.Add(fourFifths) == new Fraction(51, 20));
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
        public void Fraction_WholeNumber_ToString()
        {
            Fraction oneHalf = new Fraction(6);
            Assert.True(oneHalf.ToString() == "6");
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
    }
}
