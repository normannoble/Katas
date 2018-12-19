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
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "----------", "Unicorn!" }, Kata.Bald("/---------"));
            Assert.AreEqual(new string[] { "--------", "Homer!" }, Kata.Bald("/-----/-"));
            Assert.AreEqual(new string[] { "---------------", "Careless!" }, Kata.Bald("--/--/---/-/---"));
        }
    }
}