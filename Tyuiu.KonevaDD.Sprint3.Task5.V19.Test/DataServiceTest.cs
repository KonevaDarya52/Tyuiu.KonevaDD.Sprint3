using Tyuiu.KonevaDD.Sprint3.Task5.V19.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 1;
            int startValue2 = 3;
            int stopValue2 = 6;
            double res = ds.GetSumSumSeries(x,startValue1,stopValue2,stopValue1, stopValue2);
            double wait = 30598.002;
            Assert.AreEqual(res, wait);
        }
    }
}