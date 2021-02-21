using RecognizersTextConsoleApp;
using System;
using Xunit;

namespace RecognizersTextConsoleAppTest
{
    public class NumberWithUnitRecognizerTest
    {

        [Theory]
        [InlineData("noventa y cinco años", "95 Año")]
        [InlineData("Después de noventa y cinco años, las perspectivas cambian", "95 Año")]
        [InlineData("tres meses de vida", "3 Mes")]
        public void RecognizeAgeSimple(string phrase, string numberExpected)
        {
            var _sut = new NumberWithUnitRecognizerSpanish();
            var result = _sut.RecognizeAge(phrase);

            Assert.Equal(numberExpected, result);
        }
        

    }
}
