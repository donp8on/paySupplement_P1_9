using System;
using System.Collections;
using System.Collections.Generic;

namespace paySupplement_P1_9
{
    public class RandomFloatGenerator : IEnumerable<double>
    {
        private Random _random = new Random();
        /// <summary>
        /// Generates a random float between 0 and 1
        /// Will throw an exception if three consecutive values are less than or equal to 0.5.
        /// </summary>
        /// <returns>Returns a random float between 0.0 ad 1.0.</returns>
        /// <exception cref="InvalidSequence">This is the error message if three valuse are <= 0.5</exception>
        public IEnumerator<double> GetEnumerator()
        {
            int count = 0;
            while (true)
            {
                double value = _random.NextDouble();
                yield return value;

                if (value <= 0.5)
                    count++;
                else
                    count = 0;

                if (count >= 3)
                    throw new InvalidSequence("Three consecutive values were ≤ 0.5");
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
