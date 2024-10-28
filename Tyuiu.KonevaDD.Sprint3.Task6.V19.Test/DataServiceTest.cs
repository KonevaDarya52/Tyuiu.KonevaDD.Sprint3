using Tyuiu.KonevaDD.Sprint3.Task6.V19.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 15;
            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 45;
            Assert.AreEqual(expected, result);
        }
    }
}
