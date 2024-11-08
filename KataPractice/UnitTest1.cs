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
    [TestCase(1,"1")]
    [TestCase(1, "1")]
    public void Test1(int num, string expected)
    {
      string number = FizzTranslator(num);
      Assert.That(number, Is.EqualTo(expected));
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
      return toTranslate.ToString();
    }
  }
}