using paySupplement_P1_9;

namespace paySupplement_P1_9Test
{
    public class QuarterTest
    {
        [Fact]
        public void Quarter_Equality()
        {
            var quart1 = new Quarter(0.1);
            var quart2 = new Quarter(0.2);
            var quart3 = new Quarter(0.3);

            Assert.True(quart1 == quart2);  
            Assert.False(quart1 == quart3);
        }

        [Fact]
        public void QuarterComparison()
        {
            var q1 = new Quarter(0.1);
            var q2 = new Quarter(0.3);

            Assert.True(q1 < q2);
            Assert.True(q2 > q1);
        }

        [Fact]
        public void QuarterRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Quarter(-0.1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Quarter(1.1));
        }
    }
}
