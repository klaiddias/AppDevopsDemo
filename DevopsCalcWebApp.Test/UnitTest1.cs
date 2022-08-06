using DevopsCalcWebApp.Helper;

namespace DevopsCalcWebApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double expected = 2;
            Calc calc = new();
            // Act
            double actual = calc.Sum(1, 1);
            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}