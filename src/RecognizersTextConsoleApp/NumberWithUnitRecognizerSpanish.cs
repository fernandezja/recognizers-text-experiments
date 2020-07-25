using Microsoft.Recognizers.Text.DateTime;
using Microsoft.Recognizers.Text.Number;
using Microsoft.Recognizers.Text.NumberWithUnit;
using Microsoft.Recognizers.Text.Choice;
using Microsoft.Recognizers.Text.Sequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecognizersTextConsoleApp
{
    public class NumberWithUnitRecognizerSpanish
    {
        private readonly string _culture = "es";

        public NumberWithUnitRecognizerSpanish()
        {

        }
      
        public string RecognizeAge(string query)
        {
            var result = NumberWithUnitRecognizer.RecognizeAge(query, _culture);

            var values = result[0].Resolution.Values.ToList();
            return $"{values[1]} {values[0]}";
        }
    }
}
