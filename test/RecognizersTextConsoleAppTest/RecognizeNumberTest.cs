using RecognizersTextConsoleApp;
using System;
using Xunit;

namespace RecognizersTextConsoleAppTest
{
    public class RecognizeNumberTest
    {
        [Theory]
        [InlineData("Yo tengo dos manzanas", "2")]
        [InlineData("Yo tengo 2 manzanas", "2")]
        [InlineData("Yo tengo siete peras", "7")]
        [InlineData("Yo tengo 7 peras", "7")]
        [InlineData("Mis cincuenta centavos", "50")]
        [InlineData("Ni dos pesos", "2")]
        public void RecognizeNumberSimple(string phrase, string numberExpected)
        {
            var _sut = new RecognizeNumberSpanish();
            var result = _sut.RecognizeNumber(phrase);

            Assert.Equal(numberExpected, result);

        }
    }
}
