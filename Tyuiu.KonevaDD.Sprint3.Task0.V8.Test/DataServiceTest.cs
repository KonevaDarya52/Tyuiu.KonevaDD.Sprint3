using Tyuiu.KonevaDD.Sprint3.Task0.V8.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries (value, startValue, stopValue);
            double wait = 0.019;
                Assert.AreEqual(wait, res);
        }
    }
}