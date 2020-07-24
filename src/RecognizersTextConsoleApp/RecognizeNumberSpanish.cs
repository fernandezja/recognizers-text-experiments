﻿using Microsoft.Recognizers.Text.Number;
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

        public string RecognizeNumber(string query)
        { 
            var result  = NumberRecognizer.RecognizeNumber(query, _culture);
            //return result.ToString();
            return result[0].Resolution.Values.First().ToString();
        }
    }
}