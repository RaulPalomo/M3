using DissenyModular;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double number=34.5;
            int expectedunits = 34;
            int result = ex20.UnitPart(number, 0);
            Assert.AreEqual(expectedunits, result);
        }
        public void TestMethod2()
        {
            double number = 34.5;
            double expectedDecimals = 0.5;
            double result = ex20.DecimalPart(number, 0, 34);
            Assert.AreEqual(expectedDecimals, result);
        }
    }
}