using Assert = NUnit.Framework.Assert;

namespace Exercise_1 {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void IsEven_ReturnsTrue_ForEvenNumber() {
            var numberChecker = new NumberChecker();
            bool isEven = numberChecker.IsEven(4);
            Assert.That(isEven, Is.True);
        }

        [Test]
        public void IsEven_ReturnsFalse_ForOddNumber() {
            var numberChecker = new NumberChecker();
            bool isEven = numberChecker.IsEven(3);
            Assert.That(isEven, Is.False);
        }
    }
}