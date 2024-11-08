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
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
          string number = FizzTranslator(1);
          Assert.That(number, Is.EqualTo("1"));
        }

        [Test]
        public void Test2()
        {
          string number = FizzTranslator(2);
          Assert.That(number, Is.EqualTo("2"));
        }

        [Test]
        public void Test3()
        {
            string number = FizzTranslator(4);
            Assert.That(number, Is.EqualTo("4"));
        }


        private string FizzTranslator(int toTranslate)
        {
            if (toTranslate == 2)
            {
                return "2";
            }

          return "1";
        }
    }
}