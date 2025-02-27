using paySupplement_P1_9;

namespace paySupplement_P1_9Test
{
    public class RandomFloatTest
    {
        [Fact]
        public void ShouldTestRandomFloat()
        {
            var generator = new RandomFloatGenerator();
            var enumerator = generator.GetEnumerator();

            for (int i = 0; i < 10; i++)
            {
                enumerator.MoveNext();
                Assert.InRange(enumerator.Current, 0.0, 1.0);
            }
        }
    }
}
