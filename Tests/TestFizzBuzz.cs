using FizzBuzzDotNet;
using NUnit.Framework;

namespace Tests
{
    public class TestFizzBuzz
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestValueNotDivisibleBy3And5()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("11", fizzBuzz.Exec(11));
            Assert.AreEqual("14", fizzBuzz.Exec(14));
            Assert.AreEqual("34", fizzBuzz.Exec(34));
            Assert.AreEqual("98", fizzBuzz.Exec(98));
        }

        [Test]
        public void TestValueDivisibleBy3()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", fizzBuzz.Exec(9));
            Assert.AreEqual("Fizz", fizzBuzz.Exec(12));
            Assert.AreEqual("Fizz", fizzBuzz.Exec(33));
            Assert.AreEqual("Fizz", fizzBuzz.Exec(99));
        }

        [Test]
        public void TestValueDibisibleBy5()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", fizzBuzz.Exec(10));
            Assert.AreEqual("Buzz", fizzBuzz.Exec(95));
            Assert.AreEqual("Buzz", fizzBuzz.Exec(100));
        }

        [Test]
        public void TestValueDivisibleBy3And5()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("FizzBuzz", fizzBuzz.Exec(15));
            Assert.AreEqual("FizzBuzz", fizzBuzz.Exec(30));
            Assert.AreEqual("FizzBuzz", fizzBuzz.Exec(90));
        }
    }
}