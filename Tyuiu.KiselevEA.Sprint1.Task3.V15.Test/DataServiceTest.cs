using Tyuiu.KiselevEA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.KiselevEA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 3;
            double v2 = 2;
            double S = 6;
            double T = 30;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(T, res);
        }
    }
}