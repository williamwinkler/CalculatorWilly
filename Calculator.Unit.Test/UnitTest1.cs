using System.ComponentModel;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    public class CalculatorTests
    {

        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Calculator_Add_tests()
        {
            

            Assert.That(uut.Add(5,5), Is.EqualTo(10));
            Assert.That(uut.Add(5,2), Is.EqualTo(7));
            Assert.That(uut.Add(-3,-3), Is.EqualTo(-6));
        }

        [Test]
        public void Calculator_Substract_tests()
        {
          

            Assert.That(uut.Substract(5,5), Is.EqualTo(0));
            Assert.That(uut.Substract(5, -3), Is.EqualTo(8));
        }
    }
}