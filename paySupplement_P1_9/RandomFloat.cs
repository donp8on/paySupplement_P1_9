using System;
using System.Collections;
using System.Collections.Generic;

namespace paySupplement_P1_9
{
    public class RandomFloatGenerator : IEnumerable<double>
    {
        private Random _random = new Random();
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
