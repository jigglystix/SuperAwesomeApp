using MeasurementConvert;
using NUnit.Framework;

namespace ConvertTest
{
    public class Test
    {
        [TestCase(1, 12)] 
        [TestCase(1.083, 13)]
        public void InchesToFeet(double expectedResult, int inches)
        {
            Assert.AreEqual(expectedResult, Converter.ConvertInchesToFeet(inches));
           
        }
    }
}
