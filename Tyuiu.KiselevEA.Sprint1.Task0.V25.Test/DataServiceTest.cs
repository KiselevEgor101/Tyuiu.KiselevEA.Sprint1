using Tyuiu.KiselevEA.Sprint1.Task0.V25.Lib;

namespace Tyuiu.KiselevEA.Sprint1.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressio1()
        {
          DataService ds = new DataService();
          var res = ds.Calculate();
          Assert.AreEqual(3, res);
        }
    }
}