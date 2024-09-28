using Tyuiu.KiselevEA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KiselevEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 5;
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 0;
            Assert.AreEqual(wait, result);
        }
    }
}