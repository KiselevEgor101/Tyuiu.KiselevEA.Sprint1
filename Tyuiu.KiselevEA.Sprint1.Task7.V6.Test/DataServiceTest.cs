using Tyuiu.KiselevEA.Sprint1.Task7.V6.Lib;
namespace Tyuiu.KiselevEA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double wait = -238.438;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(wait, z);
        }
    }
}