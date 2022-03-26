using FizzBuzzDotNet;
using NUnit.Framework;

namespace Tests
{
    public class TestFizzBuzz
    {
        [Test]
        public void TestValueNotDivisibleBy3And5()
        {
            Assert.AreEqual("11", FizzBuzz.Exec(11));
            Assert.AreEqual("14", FizzBuzz.Exec(14));
            Assert.AreEqual("34", FizzBuzz.Exec(34));
            Assert.AreEqual("98", FizzBuzz.Exec(98));
        }

        [Test]
        public void TestValueDivisibleBy3()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Exec(9));
            Assert.AreEqual("Fizz", FizzBuzz.Exec(12));
            Assert.AreEqual("Fizz", FizzBuzz.Exec(33));
            Assert.AreEqual("Fizz", FizzBuzz.Exec(99));
        }

        [Test]
        public void TestValueDibisibleBy5()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Exec(10));
            Assert.AreEqual("Buzz", FizzBuzz.Exec(95));
            Assert.AreEqual("Buzz", FizzBuzz.Exec(100));
        }

        [Test]
        public void TestValueDivisibleBy3And5()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Exec(15));
            Assert.AreEqual("FizzBuzz", FizzBuzz.Exec(30));
            Assert.AreEqual("FizzBuzz", FizzBuzz.Exec(90));
        }
    }
}