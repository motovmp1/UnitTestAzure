using NUnit.Framework;

namespace NUnitTestProject8
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("first step");
        }

        [Test]
        public void Test1()
        {
            int num = 1;
            System.Console.WriteLine("second step inside");

            Assert.That(num, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            int num = 1;
            System.Console.WriteLine("second step inside");

            Assert.That(num, Is.EqualTo(1));
            System.Console.WriteLine("Pass");
        }
    }
}