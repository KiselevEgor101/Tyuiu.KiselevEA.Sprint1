using System.Runtime.Intrinsics.X86;
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
            int h = 6;
            int c = 3;
            var res = ds.ConvertHoursMinutesToSeconds(h, c);
            Assert.AreEqual(21780, res);
        }
    }
}