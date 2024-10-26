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
            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.18590230292439222;
            Assert.AreEqual(res, wait);
        }
    }
}