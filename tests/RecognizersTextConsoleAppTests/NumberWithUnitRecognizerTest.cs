using RecognizersTextConsoleApp;
using System;
using Xunit;

namespace RecognizersTextConsoleAppTest
{
    public class NumberWithUnitRecognizerTest
    {

        [Theory]
        [InlineData("noventa y cinco a�os", "95 A�o")]
        [InlineData("Despu�s de noventa y cinco a�os, las perspectivas cambian", "95 A�o")]
        [InlineData("tres meses de vida", "3 Mes")]
        public void RecognizeAgeSimple(string phrase, string numberExpected)
        {
            var _sut = new NumberWithUnitRecognizerSpanish();
            var result = _sut.RecognizeAge(phrase);

            Assert.Equal(numberExpected, result);
        }
        

    }
}
