using Tyuiu.KiselevEA.Sprint1.Task2.V11.Lib;

namespace Tyuiu.KiselevEA.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int h = 12;
            int m = 10;
            var res = ds.ConvertHoursMinutesToSeconds(h, m);
            Assert.AreEqual(1320, res);
            Assert.AreEqual(1320, res);
        }
    }
}