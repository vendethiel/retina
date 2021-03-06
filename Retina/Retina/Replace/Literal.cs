﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Retina.Replace
{
    public class Literal : Token
    {
        public string Value { get; set; }

        public Literal(string value)
        {
            Value = value;
        }

        public override string Process(string input, Match match)
        {
            return Value;
        }
    }
}
