using System.Globalization;

namespace KataPractice
{
    // Ryan
    // Leah
    // Carolina
    // Jake
    // Brandon 

    public class Tests
    {

        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(3, "Fizz")]
        public void TestFizzTranslator_IntegerToString(int num, string expected)
        {
            string number = FizzTranslator(num);
            Assert.That(number, Is.EqualTo(expected));
        }


        static string FizzTranslator(int toTranslate)
        {
            return toTranslate.ToString();
        }
    }
}