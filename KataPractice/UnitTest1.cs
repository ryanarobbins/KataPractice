using System.Globalization;

namespace KataPractice
{
    // Ryan
    // Leah
    // Carolina
    // Brandon 
    // Jake
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
          Assert.AreEqual(number, "1");
        }

        private string FizzTranslator(int i)
        {
          return "1";
        }
    }
}