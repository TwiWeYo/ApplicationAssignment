using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationAssignmentTasks.Tests
{
    [TestClass]
    public class Task1
    {
        [TestMethod]
        public void CompareWith_True_ReturnsTrue()
        {
            var someBool = new SuperpositionBoolean();
            Assert.AreEqual(someBool == true, true);
        }

        [TestMethod]
        public void CompareWith_False_ReturnsTrue()
        {
            var someBool = new SuperpositionBoolean();
            Assert.AreEqual(someBool == false, true);
        }
    }
}