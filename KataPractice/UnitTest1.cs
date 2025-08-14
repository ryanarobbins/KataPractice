namespace KataPractice
{
  public class Tests
  {
    [Test]
    public void Test()
    {
      var result = Translate(1);
      Assert.That(result, Is.EqualTo("1"));

    }

    public static string Translate(int number)
    {
      if (number == 2)
      {
        return "2";
      }
      return "1";
    }

    [Test]
    public void Test2()
    {
      var result = Translate(2);
      Assert.That(result, Is.EqualTo("2"));

    }
  }
}