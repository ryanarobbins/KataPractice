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
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(15, "FizzBuzz")]

        public void TestFizzTranslator_IntegerToString(int num, string expected)
        {
            string number = FizzTranslator(num);
            Assert.That(number, Is.EqualTo(expected));
        }


        static string FizzTranslator(int toTranslate)
        {
            if(toTranslate % 3 == 0)
            {
                return "Fizz";
            }

            if(toTranslate % 5 == 0)
            {
                return "Buzz";
            }

            return toTranslate.ToString();
        }
    }
}