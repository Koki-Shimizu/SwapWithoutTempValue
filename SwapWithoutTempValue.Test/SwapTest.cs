using System;
using NUnit.Framework;

namespace SwapWithoutTempValue.Test
{
    [TestFixture]
    public class SwapTest
    {
        [Test]
        public void Swap2_should_swap_arg_src_to_dest()
        {
            // Arrange
            int src = 0;
            int dest = 10;

            // Act
            SwapService.Swap(ref src, ref dest);

            // Assert
            Assert.AreEqual(10, src);
            Assert.AreEqual(0, dest);

        }

        [Test, TestCaseSource("TestData")]
        public void Swap2_should_(int src, int dest)
        {
            int org_src = src;
            int org_dest = dest;
            SwapService.Swap(ref src, ref dest);
            Assert.AreEqual(org_src, dest);
            Assert.AreEqual(org_dest, src);
        }

        static object[] TestData =
        {
            new object[] { 12, 3 },
            new object[] { 12, 2 },
            new object[] { 12, 4 },
            new object[] { 56666, 877 },
            new object[] { 9938383, 787878 },
            new object[] { 0, -88 },
            new object[] { -8, 0 },
            new object[] { 0, 0 },
            new object[] { -1, -1 },
            new object[] { 1, 1 }
        };
    }
}
