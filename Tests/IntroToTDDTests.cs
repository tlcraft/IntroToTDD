using IntroToTDD;
using Xunit;

namespace Tests
{
    public class IntroToTDDTests
    {
        [Fact]
        public void BestIntroToTDD_Add()
        {
            BestIntroToTDD fraction = new BestIntroToTDD();

            Assert.True(fraction.Add("7/3", "4/5") == "47/15");
        }

        [Fact]
        public void BestIntroToTDD_Add_WholeNumbers()
        {
            BestIntroToTDD fraction = new BestIntroToTDD();

            Assert.True(fraction.Add("4", "9") == "13");
        }

        /*
        
        Condidtions

        Lowest Terms = 4/6 -> 2/3
        Improper = 7/5 NOT 1 2/5
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
