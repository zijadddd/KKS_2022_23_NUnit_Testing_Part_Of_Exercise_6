namespace Exercise_3 {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void CalculateSum_ReturnsZero_ForEmptyArray() {
            var calculator = new Calculator();
            Assert.That(calculator.CalculateSum(new int[] { }), Is.EqualTo(0));
        }

        [Test]
        public void CalculateSum_ReturnsSum_ForNotEmptyArray() {
            var calculator = new Calculator();
            Assert.That(calculator.CalculateSum(new int[] { 1, 2, 3 }), Is.EqualTo(6));
        }

        [Test]
        public void ReverseString_ReturnsEmptyString_ForEmptyString() {
            var stringHelper = new StringHelper();
            Assert.That(stringHelper.ReverseString(""), Is.EqualTo(""));
        }

        [Test]
        public void ReverseString_ReturnsReversedString_ForString() {
            var stringHelper = new StringHelper();
            Assert.That(stringHelper.ReverseString("abc"), Is.EqualTo("cba"));
        }
    }
}