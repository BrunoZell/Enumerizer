using System.Linq;
using Xunit;
using static Enumerizer;

namespace BrunoZell.Enumerizer.Tests
{
    public class IterationTests
    {
        [Fact]
        public void Test1()
        {
            int[] it = (1 < i <= 5).ToArray();

            Assert.Equal(2, it.First());
            Assert.Equal(5, it.Last());
        }

        [Fact]
        public void Test2()
        {
            int[] it = (-10 <= i <= 5).ToArray();

            Assert.Equal(-10, it.First());
            Assert.Equal(5, it.Last());
        }

        [Fact]
        public void Test3()
        {
            int[] it = (0 <= i < 3).ToArray();

            Assert.Equal(0, it.First());
            Assert.Equal(2, it.Last());
        }

        [Fact]
        public void Test4()
        {
            int[] it = (99 >= i > 3).ToArray();

            Assert.Equal(99, it.First());
            Assert.Equal(4, it.Last());
        }

        [Fact]
        public void Test5()
        {
            int[] it = (100 > i >= 90).ToArray();

            Assert.Equal(99, it.First());
            Assert.Equal(90, it.Last());
        }

        [Fact]
        public void Test6()
        {
            int[] it = (0 <= i <= 6 | 2).ToArray();

            Assert.Equal(4, it.Length);
        }
    }
}
