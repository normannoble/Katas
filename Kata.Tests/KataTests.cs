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
        public void ValidBraces_WithValidPatterns_ReturnsTrue()
        {
            Assert.AreEqual(true, Kata.ValidBraces("()"));
            Assert.AreEqual(true, Kata.ValidBraces("()[]{}"));
            Assert.AreEqual(true, Kata.ValidBraces("({[]})"));
            Assert.AreEqual(true, Kata.ValidBraces("({[]})()"));
            Assert.AreEqual(true, Kata.ValidBraces("()({[]})"));
            Assert.AreEqual(true, Kata.ValidBraces("{{}{}}"));
            Assert.AreEqual(true, Kata.ValidBraces("{}{{}}"));
            Assert.AreEqual(true, Kata.ValidBraces("{{}}{}"));
            Assert.AreEqual(true, Kata.ValidBraces("[{{[(){}]}}[]{}{{(())}}]"));
        }
        [Test]
        public void ValidBraces_WithInvalidPatterns_ReturnsFalse()
        {
            Assert.AreEqual(false, Kata.ValidBraces(""));
            Assert.AreEqual(false, Kata.ValidBraces("("));
            Assert.AreEqual(false, Kata.ValidBraces(")"));
            Assert.AreEqual(false, Kata.ValidBraces("))"));
             Assert.AreEqual(false, Kata.ValidBraces(")))"));
            Assert.AreEqual(false, Kata.ValidBraces("[[["));
            Assert.AreEqual(false, Kata.ValidBraces("[[[["));
            Assert.AreEqual(false, Kata.ValidBraces("[(])"));
            Assert.AreEqual(false, Kata.ValidBraces("]()"));
            Assert.AreEqual(false, Kata.ValidBraces("[(])"));
            Assert.AreEqual(false, Kata.ValidBraces("}()}"));
            Assert.AreEqual(false, Kata.ValidBraces("({[]}("));
            Assert.AreEqual(false, Kata.ValidBraces("({[)}]"));
        }
    }
}