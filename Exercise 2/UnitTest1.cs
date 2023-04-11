using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Exercise_2 {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void AverageOverASeriesOfPositiveNumbers() {
            var numberProcessor = new NumberProcessor();
            int[] nums = {1, 2, 3, 4, 5};
            var result = numberProcessor.GetAverage(nums);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AverageOverASeriesOfNegativeNumbers() {
            var numberProcessor = new NumberProcessor();
            int[] nums = { -1, -2, -3, -4, -5 };
            var result = numberProcessor.GetAverage(nums);
            Assert.That(result, Is.EqualTo(-3));
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AverageOverASeriesOfEmptyArray() {
            var numberProcessor = new NumberProcessor();
            Assert.Throws<ArgumentException>(() => numberProcessor.GetAverage(new int[] {}));
        }

        [Test]
        public void isTwoPrimeNumber() {
            var numberProcessor = new NumberProcessor();
            Assert.That(numberProcessor.IsPrime(2), Is.True);
        }

        [Test]
        public void isThreePrimeNumber() {
            var numberProcessor = new NumberProcessor();
            Assert.That(numberProcessor.IsPrime(3), Is.True);
        }

        [Test]
        public void isFourPrimeNumber() {
            var numberProcessor = new NumberProcessor();
            Assert.That(numberProcessor.IsPrime(4), Is.False);
        }

        [Test]
        public void theLargestElementInASeriesOfPositiveNumbers() {
            var numberProcessor = new NumberProcessor();
            int[] nums = { 1, 2, 3, 4 };
            Assert.That(numberProcessor.GetLargest(nums), Is.EqualTo(4));
        }

        [Test]
        public void theLargestElementInASeriesOfNegativeNumbers() {
            var numberProcessor = new NumberProcessor();
            int[] nums = { -1, -2, -3, -4 };
            Assert.That(numberProcessor.GetLargest(nums), Is.EqualTo(-1));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void theLargestElementInAEmptyArray() {
            var numberProcessor = new NumberProcessor();
            Assert.Throws<ArgumentException>(() => numberProcessor.GetLargest(new int[] {}));
        }
    }
}