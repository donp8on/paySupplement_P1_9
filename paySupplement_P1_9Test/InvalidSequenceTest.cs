using paySupplement_P1_9;
namespace paySupplement_P1_9Test
{
    public class InvalidSequenceTest
    {
        [Fact]
        public void ShouldTestInvalidSequenceException()
        {
            var generator = new RandomFloatGenerator();
            var enumerator = generator.GetEnumerator();

            Assert.Throws<InvalidSequence>(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    enumerator.MoveNext();
                }
            });
        }

    }
}