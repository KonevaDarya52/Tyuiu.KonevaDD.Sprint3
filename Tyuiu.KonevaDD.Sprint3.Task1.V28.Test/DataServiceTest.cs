using Tyuiu.KonevaDD.Sprint3.Task1.V28.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();
            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double res = ds.GetSumSeries(a, startValue, stopValue);
            double expected = -0.186;
            Assert.AreEqual(expected, res);
        }
    }
}