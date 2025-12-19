namespace FizzBuzz.Tests
{
    [TestClass]
    public sealed class FizzBuzzReturnsString
    {
        [TestMethod]
        [DataRow(0)]
        public void GivenIntegerReturnsaString(int input)
        {
            var result = FizzBuzzer.Get(input);

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
