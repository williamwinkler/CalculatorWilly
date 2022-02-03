using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
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
        public void Add_add5and3_result8()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Add(3);

            // Assert
            Assert.AreEqual(8, uut.Accumulator);
        }

        [Test]
        public void Add_add5andMinus10_resultMinus5()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Add(-10);

            // Assert
            Assert.AreEqual(-5, uut.Accumulator);
        }

        [Test]
        public void Subtract_Add5Subtract5_result0()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Subtract(5);

            // Assert
            Assert.AreEqual(0, uut.Accumulator);
        }

        [Test]
        public void Subtract_Add5SubtractMinus5_result10()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Subtract(-5);

            // Assert
            Assert.AreEqual(10, uut.Accumulator);
        }

        [Test]
        public void Multiply_5timesMinus3_resultMinus15()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Multiply(-3);

            // Assert
            Assert.AreEqual(-15, uut.Accumulator);
        }

        [Test]
        public void Pow_5toThePowerOf2_result25()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Pow(2);

            // Assert
            Assert.AreEqual(25, uut.Accumulator);
        }

        [Test]
        public void Pow_minus5toThePowerOf2_result25()
        {
            // Arrange

            // Act
            uut.Add(-5);
            uut.Pow(2);

            // Assert
            Assert.AreEqual(25, uut.Accumulator);
        }

        [Test]
        public void Divide_5dividedWithMinus5_resultMinus1()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Divide(-5);

            // Assert
            Assert.AreEqual(-1, uut.Accumulator);
        }

        [Test]
        public void Divide_5dividedWith0_resultException()
        {
            // Arrange

            // Act
            uut.Add(5);
            
            // Assert
            Assert.Throws<DivideByZeroException>(() => uut.Divide(0));
        }

        [Test]
        public void Clear_AccIs5ThenClear_result0()
        {
            // Arrange

            // Act
            uut.Add(5);
            uut.Clear();

            // Assert
            Assert.AreEqual(0, uut.Accumulator);
        }

    }
}