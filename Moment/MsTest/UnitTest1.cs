using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Moment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IinstrumentCalculator calculator = new InstrumentCalculatorImpl();
            calculator.addElement(1.0);
            calculator.addElement(2.0);

            Assert.AreEqual(-0.5, calculator.firstMomentAbout(2.0), TOLERANCE);
        }
    }
}
