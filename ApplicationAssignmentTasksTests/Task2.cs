using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationAssignmentTasks.Tests
{
    [TestClass]
    public class Task2
    {
        private FluentCalculator FluentCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            FluentCalculator = new FluentCalculator();
        }

        [TestMethod]
        public void Input_Five_Returns_Five()
        {
            var result = FluentCalculator.five;

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Input_OneOne_Throws_InvalidOperationException()
        {
            var result = FluentCalculator.one.one;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Input_OnePlusPlus_Throws_InvalidOperationException()
        {
            var result = FluentCalculator.one.plus.plus;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_StartWithOperation_ThrowsException()
        {
            var result = FluentCalculator.times;
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ThrowsDivideByZeroException()
        {
            var result = FluentCalculator.three.dividedBy.zero;
        }

        [TestMethod]
        public void Input_OnePlusTwo_Returns_Three()
        {
            var result = FluentCalculator.one.plus.two;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Input_SevenMinusFour_Returns_Three()
        {
            var result = FluentCalculator.seven.minus.four;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Input_TwoTimesFour_Returns_Eight()
        {
            var result = FluentCalculator.two.times.four;

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Input_NineDividedByThree_Returns_Three()
        {
            var result = FluentCalculator.nine.dividedBy.three;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test_WorksWithNegative()
        {
            var result = FluentCalculator.one.minus.seven;

            Assert.AreEqual(-6, result);
        }

        [TestMethod]
        public void Test_ChainInputs()
        {
            var result = FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four;

            Assert.AreEqual(-1, result);
        }
    }
}