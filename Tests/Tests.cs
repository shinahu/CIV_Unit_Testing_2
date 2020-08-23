using System;
using Xunit;

namespace Tests
{
    public class MiscLibTests
    {
        GroupTwoFunctions z = new GroupTwoFunctions();

        [Theory]
        [InlineData(18, 2, 7)]
        

        public void CalcRectPerimeterTest(int answere, int lenght, int widht)
        {
            Assert.Equal(expected, z.CalcRectPerimeterTest(lenght, widht));

        }

        // 2. Checks if a number is a triangular number
        [Theory]
        [Inlinedata(true, 6)]
        [Inlinedata(false,7)]
        public void IsTriangularNum_Test(bool answere, int num)
        {
            Assert.Equals(answere, z.IsTriangularNum(num));
        }

        // 3. Coverts a temperature from Farenheit to Celcius, rounded up to the nearest whole number
        [Theory]
        [Inlinedata(6, 43)]
        [Inlinedata(9,48)]
        public void FarenheitToCelcius_Test(int answere, int farenheit)
        {
            Assert.Equal(answere, z.FarenheitToCelcius(farenheit));
        }

        // 4. Checks a string for either leading or trailing white spaces
        [Theory]
        [Inlinedata(true, "Homer  ")]
        [Inlinedata(true, "Simpson ")]

        public void CheckWhiteSpace_Test(bool answere, string word)
        {
            Assert.Equals(answere, z.CheckWhiteSpace(word));
        }

        // 5. Takes a string and makes every odd letter uppercase and every even letter lowercase
        [Theory]
        [Inlinedata("HoMeR", "Homer")]
        [Inlinedata("SiMpSoN", "Simpson")]
        public void CamelString_Test(string answere, string word)
        {
            Assert.Equal(answere, z.CamelString(word));
        }

        // 6. Counts the number of digits found in a string
        [Theory]
        [Inlinedata(5, "98765")]
        [Inlinedata(5, "Homer")]
        public void CountDigits_Test(int answere, string word)
        {
            Assert.Equal(answere, z.CountDigits(word));
        }
    }
}
