using NUnit.Framework;

namespace Kata.Tests
{
    using Kata.Library;

    public class KataTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = Kata.comp(a, b); // True
            Assert.AreEqual(true, r);
        }
    }
}