namespace KataPractice
{

    public class Tests
    {
        public string Fizzbuzz(int number)
        {
            if (number == 3 || number == 6)
            {
                return "Fizz";
            }
            return number.ToString();
        }

        [Test]
        public void Test()
        {
            var result = Fizzbuzz(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Test2()
        {
            var result = Fizzbuzz(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Test3()
        {
            var result = Fizzbuzz(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Test6()
        {
            var result = Fizzbuzz(6);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}