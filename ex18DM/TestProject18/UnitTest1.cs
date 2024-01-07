using DissenyModular;

namespace TestProject18
{
    [TestClass]
    public class ex18test
    {
        [TestMethod]
        public void CalcSecondsTest()
        {
            // Arrange
            int temps = 5;
            int expectedSeconds = 5 * 60;

            // Act
            int result = ex18.CalcSeconds(temps);

            // Assert
            Assert.AreEqual(expectedSeconds, result);
        }
    }
}