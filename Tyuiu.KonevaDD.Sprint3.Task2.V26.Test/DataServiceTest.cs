using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevaDD.Sprint3.Task1.V26.Lib;

namespace Tyuiu.KonevaDD.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;

            double result = ds.GetSumSeries(value, startValue, stopValue);

            double expected = 411589.5372020042; 
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
