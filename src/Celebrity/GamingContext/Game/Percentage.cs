﻿using System;
using System.Collections.Generic;

namespace Celebrity.GamingContext
{
    public class Percentage : ValueObject
    {
        private readonly decimal value;
        public string DecimalValue => Math.Round(value, 2).ToString();
        public string IntValue => Math.Round(value, 0).ToString();

        public Percentage(decimal value)
        {
            this.value = value;
        }

        public Percentage(decimal numerator, decimal denominator)
        {
            value = numerator / denominator * 100;
        }

        public static implicit operator decimal(Percentage percentage) => percentage.value;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public override string ToString() => $"{IntValue}/100";
    }
}
