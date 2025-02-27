using System;
using System.Collections;
using System.Collections.Generic;

namespace paySupplement_P1_9
{
    public class Quarter
    {
        /// <summary>
        /// This gets the value of the quarter.
        /// </summary>
        public double Value { get; }

        public Quarter(double value)
        {
            if (value < 0.0 || value >= 1.0)
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be in range [0.0, 1.0)");
            Value = value;
        }

        private int GetQuarter() => (int)(Value * 4);

        public static bool operator ==(Quarter a, Quarter b) => a.GetQuarter() == b.GetQuarter();
        public static bool operator !=(Quarter a, Quarter b) => !(a == b);
        public static bool operator >(Quarter a, Quarter b) => a.Value > b.Value;
        public static bool operator <(Quarter a, Quarter b) => a.Value < b.Value;
        public static bool operator >=(Quarter a, Quarter b) => a.Value >= b.Value;
        public static bool operator <=(Quarter a, Quarter b) => a.Value <= b.Value;
    }
}
