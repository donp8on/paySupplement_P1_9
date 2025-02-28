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

        /// <summary>
        /// This is the constructor for the Quarter class.
        /// </summary>
        /// <param name="value"> Value is a double that is between 0.0 and 1.0.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throws an exception if the value is not in the range [0.0, 1.0).</exception>
        public Quarter(double value)
        {
            if (value < 0.0 || value >= 1.0)
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be in range [0.0, 1.0)");
            Value = value;
        }

        private int GetQuarter() => (int)(Value * 4);

        /// <summary>
        /// Determines if two Quarter values belong to the same quarter.
        /// </summary>
        public static bool operator ==(Quarter a, Quarter b) => a.GetQuarter() == b.GetQuarter();

        /// <summary>
        /// Determines if two Quarter values belong to different operators.
        /// </summary>
        public static bool operator !=(Quarter a, Quarter b) => !(a == b);

        /// <summary>
        /// Determines if one quarter is greater than the other quater.
        /// </summary>
        public static bool operator >(Quarter a, Quarter b) => a.Value > b.Value;

        /// <summary>
        /// Determines if one quarter is less than the other quater.
        /// </summary>
        public static bool operator <(Quarter a, Quarter b) => a.Value < b.Value;

        /// <summary>
        /// Determines if one quarter is greather than or equal to the other quater.
        /// </summary>
        public static bool operator >=(Quarter a, Quarter b) => a.Value >= b.Value;
        public static bool operator <=(Quarter a, Quarter b) => a.Value <= b.Value;
    }
}
