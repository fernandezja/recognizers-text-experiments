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
    public class RecognizeNumberSpanish
    {
        private readonly string _culture = "es";

        public RecognizeNumberSpanish()
        {

        }

        public SortedDictionary<string, object> RecognizeNumber(string query)
        { 
            var result  = NumberRecognizer.RecognizeNumber(query, _culture);            
            return result[0].Resolution;
        }


        public SortedDictionary<string, object> RecognizeOrdinal(string query)
        {
            var result = NumberRecognizer.RecognizeOrdinal(query, _culture);
            return result[0].Resolution;
        }


        public SortedDictionary<string, object> RecognizePercentage(string query)
        {
            var result = NumberRecognizer.RecognizePercentage(query, _culture);
            return result[0].Resolution;
        }


        public SortedDictionary<string, object> RecognizeNumberRange(string query)
        {
            var result = NumberRecognizer.RecognizeNumberRange(query, _culture);
            return result[0].Resolution;
        }

    }
}
