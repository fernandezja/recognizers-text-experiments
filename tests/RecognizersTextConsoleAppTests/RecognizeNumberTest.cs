using RecognizersTextConsoleApp;
using System;
using Xunit;

namespace RecognizersTextConsoleAppTest
{
    public class RecognizeNumberTest
    {
        [Theory]
        [InlineData("Yo tengo dos manzanas", "2", "integer")]
        [InlineData("Yo tengo 2 manzanas", "2", "integer")]
        [InlineData("Yo tengo siete peras", "7", "integer")]
        [InlineData("Yo tengo 7 peras", "7", "integer")]
        [InlineData("Mis cincuenta centavos", "50", "integer")]
        [InlineData("Ni dos pesos", "2", "integer")]
        [InlineData("Mas vale pajaro en mano que cien volando", "100", "integer")]
        public void RecognizeNumberSimple(string phrase, string numberExpected, string subtypeExpected)
        {
            var _sut = new RecognizeNumberSpanish();
            var result = _sut.RecognizeNumber(phrase);

            Assert.Equal(subtypeExpected, result["subtype"]);
            Assert.Equal(numberExpected, result["value"]);

        }


        [Theory]
        [InlineData("primero", "1")]
        [InlineData("segundo", "2")]
        [InlineData("tercero", "3")]
        [InlineData("decimo primero", "11")]
        [InlineData("decimo quinto", "15")]
        [InlineData("decimoquinto", "15")]
        [InlineData("vigesimo septimo", "27")]
        [InlineData("trigesimo segundo", "32")]
        [InlineData("sexagesimo cuarta", "64")]
        [InlineData("centesimo sexta", "106")]
        [InlineData("milesimo", "1000")]
        [InlineData("millonesimo", "1000000")]
        public void RecognizeOrdinalSimple(string phrase, string numberExpected)
        {
            var _sut = new RecognizeNumberSpanish();
            var result = _sut.RecognizeOrdinal(phrase);

            Assert.Equal(numberExpected, result["offset"]);
            Assert.Equal("start", result["relativeTo"]);
            Assert.Equal(numberExpected, result["value"]);

        }


        [Theory]
        [InlineData("entre uno y dos", "[1,2)")]
        [InlineData("entre 10 y quince", "[10,15)")]
        [InlineData("entre veintidos y 33", "[22,33)")]
        public void RecognizeNumberRangeSimple(string phrase, string numberExpected)
        {
            var _sut = new RecognizeNumberSpanish();
            var result = _sut.RecognizeNumberRange(phrase);

            Assert.Equal(numberExpected, result["value"]);
        }


        

    }
}
