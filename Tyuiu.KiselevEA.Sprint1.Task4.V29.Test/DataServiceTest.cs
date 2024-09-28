using Tyuiu.KiselevEA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.KiselevEA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double wait = 0.024;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}