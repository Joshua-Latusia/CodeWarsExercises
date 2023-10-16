using CodeWarsExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests
{
    [TestClass]
    public class APlusBTests
    {
        [TestMethod]
        public void TestSum()
        {
            byte a = 1;
            byte b = 2;
            Assert.AreEqual(3, APlusB.Sum(a, b));
        }
    }
}
