using Tyuiu.KonevaDD.Sprint3.Task3.V16.Lib;
namespace Tyuiu.KonevaDD.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCharCount()
        {
            DataService ds = new DataService();
            string str = "ice nice ice creamcc";
            char chr = 'c';
            double res = ds.GetCharCount(str, chr);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}